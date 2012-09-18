using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace VK
{
	public class UrlParamsManager
	{
		private const string REGEX_MATCH_PATTERN = @"(?<name>\w+)=(?<value>(?:@[a-z][\w]*))";
		private const string REGEX_REPLACE_AMPERSANDS = @"(&{2,})";
		private NameValueCollection list = new NameValueCollection();
		private string template = String.Empty;
		private MatchCollection matched;

		public UrlParamsManager(string input)
		{
			if ((matched = Regex.Matches(input, REGEX_MATCH_PATTERN, RegexOptions.IgnoreCase)).Count > 0)
			{
				template = input;
			}
			//else
			//{
			//    throw new Exception("Passed template string not valid");
			//}
		}

		public void AddValueByName(string name, object value)
		{
			if (value == null)
				return;
			if (name.StartsWith("@"))
				list.Add(name, ParamConverter.Convert(value));
			else
				throw new Exception("Passed value ID not valid");
		}

		public string GetUrlParams()
		{
			string retValue = template;
			foreach (Match match in matched)
			{
				string name = match.Groups["value"].Value;
				string value = list.Get(name);
				if (value == null)
				{
					continue;
				}
				retValue = retValue.Replace(name, value);
			}
			list.Clear();
			return DeleteUnusedParams(retValue);
		}

		private string DeleteUnusedParams(string input)
		{
			string temp = Regex.Replace(input, REGEX_MATCH_PATTERN, String.Empty);
			temp = temp.Trim(new char[] { '&' });
			return Regex.Replace(temp, REGEX_REPLACE_AMPERSANDS, "&", RegexOptions.IgnoreCase);
		}
	}
}