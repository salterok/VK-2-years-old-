using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
//using Newtonsoft.Json;
using System.Xml.Linq;

namespace VK
{
	public class VKResponseBase
	{
		const string RESPONSE_NODE_NAME_ERROR = "error";
		const string RESPONSE_NODE_NAME_ERROR_CODE = "error_code";
		const string RESPONSE_NODE_NAME_ERROR_MSG = "error_msg";
		const string RESPONSE_NODE_NAME_REQUEST_PARAMS = "request_params";
		const string RESPONSE_NODE_NAME_PARAM = "param";
		const string INTERNAL_NOT_IMPLEMENTED_ERROR = "Internal error: Not Implemented";

		public bool IsError { get; protected set; }
		public string ResponseSource { get; protected set; }
		public VKErrorResponse Error { get; protected set; }

		public VKResponseBase(string source, bool is_xml)
		{
			ResponseSource = source;
			if (is_xml)
			{
				tryParseError_XML(source);
			}
			else
			{
				tryParseError_JSON(source);
			}
		}

		private void tryParseError_JSON(string source)
		{
			//using (var reader = new JsonTextReader(new StringReader(source)))
			//{
			//	// TODO: 

			//}
			// if someone will caught exception
			IsError = true;
			Error = new VKErrorResponse()
			{
				Code = -1,
				Message = INTERNAL_NOT_IMPLEMENTED_ERROR,
				RequestParams = new KeyValuePair<string,string>[0]
			};
			
			throw new NotImplementedException();
		}

		private void tryParseError_XML(string source)
		{
			var doc = XDocument.Parse(source);

			if (doc.Root.Name == RESPONSE_NODE_NAME_ERROR)
			{
				Error = new VKErrorResponse()
				{
					Code = Int32.Parse(doc.Root.Element(RESPONSE_NODE_NAME_ERROR_CODE).Value),
					Message = doc.Root.Element(RESPONSE_NODE_NAME_ERROR_MSG).Value,
					RequestParams = (
									from node
									in doc.Root.Elements(RESPONSE_NODE_NAME_REQUEST_PARAMS).Elements(RESPONSE_NODE_NAME_PARAM)
									select new KeyValuePair<string, string>(
										node.Element("key").Value,
										node.Element("value").Value
										)
									).ToArray()
				};
				IsError = true;
			}
			else
			{
				Error = new VKErrorResponse()
				{
					Code = 0,
					Message = String.Empty,
					RequestParams = new KeyValuePair<string, string>[0]
				};
				IsError = false;
			}
		}
	}
}
