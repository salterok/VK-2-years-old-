#define NO_CHECK

using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace VK
{
	public class VKAPIBranch
	{
		private const string CAN_NOT_BE_INITIALIZED = "Object can't be initialized. Maybe resources are corrupted";
		private const string WRONG_BASE_STATE = "Something goes wrong while creating object. Maybe authorization failed";
		private const string NOT_INITIALIZED = "The object is created but not initialized";
		private const string INITIALIZED = "The object is initialized";
		private const string API_BASE = "https://api.vk.com/method/";
		private static UrlParamsByBranchesManager paramsManager;
		internal static bool error = false;
		private bool _isError = true;

		protected string API_URI_BASE
		{
			get
			{
				return String.Format(API_URI_BASE_TEMPLATE, "{0}", IsXMLResponse ? ".xml" : String.Empty);
			}
			set
			{
				API_URI_BASE_TEMPLATE = value;
			}
		}

		protected string API_URI_BASE_TEMPLATE = API_BASE + "{0}{1}?";
		protected UrlParamsManager manager = null;
		protected string token = String.Empty;

		/// <summary>
		/// Возвращает ответ сервера.
		/// </summary>
		/// <param name="method">имя API-метода, который нужно вызвать.</param>
		/// <param name="overrideMethodName">указывает необходимо ли переопределить имя API-метода.</param>
		/// <returns></returns>
		protected string GetResponse(string method, bool overrideMethodName = false)
		{
			manager.AddValueByName("@access_token", token);
			string paramsString = manager.GetUrlParams();
			if (IsError)
			{
				return String.Empty;
			}
			return Network.GetHTML(
				(
				overrideMethodName ?
				String.Format("{0}{1}{2}{3}", API_BASE, method, (IsXMLResponse ? ".xml" : String.Empty), "?") :
				String.Format(this.API_URI_BASE, method)
				) +
				paramsString);
		}

		/// <summary>
		/// Текущее состояние объекта.
		/// </summary>
		public string State
		{
			get;
			protected set;
		}

		/// <summary>
		/// Если значение <value>true</value>, то ответ будет в формате XML иначе - JSON.
		/// </summary>
		public bool IsXMLResponse
		{
			get;
			private set;
		}

		/// <summary>
		/// Если значение <value>true</value>, то произошла ошибка, описание которой можно получить из свойства <paramref name="State"/>.
		/// </summary>
		public bool IsError
		{
			get
			{
				return error | _isError;
			}
			protected set
			{
				_isError = value;
			}
		}

		/// <summary>
		/// Статический конструктор, инициализирующий строку параметров для обращения к API.
		/// </summary>
		static VKAPIBranch()
		{
			try
			{
				XmlDocument document = new XmlDocument();
				document.LoadXml(Resources.UrlParamsByBranches);
#if NO_CHECK
				/*
#endif
				XmlSchema schema = new System.Xml.Schema.XmlSchema();
				bool valid = true;
				schema = XmlSchema.Read(new MemoryStream(Encoding.UTF8.GetBytes(Resources.UrlParamsByBranchesSchema)),
					(sender, e) => valid = false);
				if (!valid)
					throw new XmlException("Schema is not valid.");
				document.Schemas.Add(schema);
				valid = true;
				document.Validate((sender, e) => valid = false);
				if (!valid)
					throw new XmlException("Document is not valid.");
#if NO_CHECK
				*/
#endif
				paramsManager = new UrlParamsByBranchesManager(document);
			}
			catch (System.Exception)
			{
				error = true;
			}
		}

		/// <summary>
		/// Создает неинициализированый объект.
		/// </summary>
		/// <param name="needXml">Указывает необходим ли ответ в формате XML.</param>
		public VKAPIBranch(bool needXml)
		{
			if (error)
			{
				State = WRONG_BASE_STATE;
			}
			else
			{
				State = NOT_INITIALIZED;
			}
			IsXMLResponse = needXml;
			IsError = true;
		}

		/// <summary>
		/// Инициализирует объект.
		/// </summary>
		/// <param name="key">Ключ доступа access_token.</param>
		public void Initialize(string key)
		{
			token = key;
			try
			{
				manager = new UrlParamsManager(paramsManager[this.GetType().Name]);
			}
			catch (System.Exception)
			{
				this.State = CAN_NOT_BE_INITIALIZED;
				this.IsError = true;
				manager = new UrlParamsManager(String.Empty);
				return;
			}
			if (!error)
			{
				State = INITIALIZED;
				IsError = false;
			}
		}

		/// <summary>
		/// Возвращает тип объекта и его текущее состояние.
		/// </summary>
		/// <returns>Возвращает строку, содержащую тип объекта, указание произошла ли ошибка, формат ответа и текущее состояние.</returns>
		public override string ToString()
		{
			string retValue = String.Format("Class: {0}.\nIsError: {1}.\nResponse Type: {2}.\nState: {3}.",
				this.GetType().Name, this.IsError, this.IsXMLResponse ? "XML" : "JSON", this.State);
			return retValue;
		}
	}
}