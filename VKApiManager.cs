using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using VK.Authorization;

namespace VK
{
	public partial class VKApiManager
	{
		private AuthorizationDetails authorizationDetails;

		public AuthorizationDetails AuthorizationDetails {
			get {
				return authorizationDetails;
			}
		}
		private bool status;

		/// <summary>
		/// Если значение <value>true</value>, то ответ будет в формате XML иначе - JSON.
		/// </summary>
		public bool IsXmlResponseNeeded
		{
			get;
			private set;
		}

		public Users users
		{
			get;
			private set;
		}

		public Friends friends
		{
			get;
			private set;
		}

		public Photos photos
		{
			get;
			private set;
		}

		public Wall wall
		{
			get;
			private set;
		}

		public Newsfeed newsfeed
		{
			get;
			private set;
		}

		public Audio audio
		{
			get;
			private set;
		}

		public Video video
		{
			get;
			private set;
		}

		public Docs docs
		{
			get;
			private set;
		}

		public Notes notes
		{
			get;
			private set;
		}

		public Pages pages
		{
			get;
			private set;
		}

		public Places places
		{
			get;
			private set;
		}

		public Secure secure
		{
			get;
			private set;
		}

		public SMS sms
		{
			get;
			private set;
		}

		public Subscriptions subscription
		{
			get;
			private set;
		}

		public Storage storage
		{
			get;
			private set;
		}

		public App app
		{
			get;
			private set;
		}

		public Execute execute
		{
			get;
			private set;
		}

		public Obsolete obsolete
		{
			get;
			private set;
		}

		public VKApiManager(AuthorizationDetails details, bool xmlNeeded = true)
		{
			IsXmlResponseNeeded = xmlNeeded;
			status = Init(details);
		}

		public VKApiManager(int appId, AccessRights rights, bool xmlNeeded = true)
		{
			AuthorizationDetails details = new AuthorizationDetails();
			details.appId = appId;
			details.rights = rights;
			IsXmlResponseNeeded = xmlNeeded;
			status = Init(details);
		}

		public VKApiManager(string appId, AccessRights rights, bool xmlNeeded = true)
		{
			AuthorizationDetails details = new AuthorizationDetails();
			if (Int32.TryParse(appId, out details.appId))
			{
				details.rights = rights;
				IsXmlResponseNeeded = xmlNeeded;
				status = Init(details);
			}
			else
			{
				status = false;
			}
		}

		/// <summary>
		/// Вызывается одним из конструкторов класса и служит для проведения авторизации клиента.
		/// </summary>
		/// <param name="details">Информация, необходимая для авторизации. Для успешной авторизации обязательны валидные поля
		/// <paramref name="AuthorizationDetails.appId"/> и <paramref name="AuthorizationDetails.rights"/>.</param>
		/// <returns>Возвращает <paramref name="DialogResult.Yes"/> в случае успешной авторизации, иначе - <paramref name="DialogResult.No"/>.</returns>
		private bool Init(AuthorizationDetails details)
		{
			bool retValue = true;
			if (details.appId < 0 || details.rights == AccessRights.NO_RIGHTS)
			{
				retValue = false;
			}
			if (retValue)
			{
				authorizationDetails = details;
				AuthorizationWindow authWindow = new AuthorizationWindow(ref authorizationDetails);
				if (authWindow.ShowDialog() == DialogResult.Yes)
				{
					retValue = true;
				}
				else
				{
					retValue = false;
				}
			}
			InitAPI(retValue);
			return retValue;
		}

		/// <summary>
		/// Инициализирует все вложеные классы наследованые от <typeparamref name="VKAPIBranch"/> и предоставляющие доступ к разным группам API.
		/// </summary>
		private void InitAPI(bool isError)
		{
			if (!isError)
			{
				VKAPIBranch.error = true;
			}
			var branches = this.GetType().GetProperties().Where(item => item.PropertyType.IsSubclassOf(typeof(VKAPIBranch)));
			foreach (PropertyInfo property in branches)
			{
				property.SetValue(this, Activator.CreateInstance(property.PropertyType, new object[] { IsXmlResponseNeeded }), null);
				(property.GetValue(this, null) as VKAPIBranch).Initialize(this.authorizationDetails.accessToken);
			}
		}
	}
}