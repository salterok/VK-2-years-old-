using System;

//using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml;

namespace VK
{
	internal class UrlParamsByBranchesManager
	{
		private NameValueCollection dependentParams = new NameValueCollection();
		private string globalParams;

		public UrlParamsByBranchesManager(XmlDocument document)
		{
			XmlNodeList depend = document.DocumentElement.SelectNodes("/Params/DependentParams/*");
			foreach (XmlNode node in depend)
			{
				string line = String.Empty;
				foreach (XmlNode item in node.ChildNodes)
				{
					line += String.Format("{0}={1}&", item.Attributes["Name"].Value, item.Attributes["Template"].Value);
				}
				line = line.Remove(line.Length - 1);
				dependentParams.Add(node.Name, line);
			}
			XmlNode global = document.DocumentElement.SelectSingleNode("/Params/GlobalParams");
			if (global != null)
			{
				String line = String.Empty;
				foreach (XmlNode node in global.ChildNodes)
				{
					line += String.Format("{0}={1}&", node.Attributes["Name"].Value, node.Attributes["Template"].Value);
				}
				line = line.Remove(line.Length - 1);
				globalParams = line;
			}
		}

		public string this[string branch]
		{
			get
			{
				return (this.dependentParams[branch] ?? String.Empty) + String.Format("&{0}", this.globalParams);
			}
		}
	}
}