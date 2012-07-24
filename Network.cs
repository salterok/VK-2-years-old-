using System.IO;
using System.Net;
using System.Text;

namespace VK
{
	public static class Network
	{
		public static string GetHTML(string url)
		{
			string html = null;

			HttpWebResponse response = null;
			HttpWebRequest request = null;
			TextReader reader = null;
			try
			{
				request = (HttpWebRequest)HttpWebRequest.Create(url);
				request.AllowAutoRedirect = true;
				response = (HttpWebResponse)request.GetResponse();
				if (response.ContentLength > 0x100000)
					return null;
				if (request.ContentLength > 0x100000)
					return null;

				Encoding encoding;
				if (response.CharacterSet.ToLower() == "windows-1251")
				{
					encoding = Encoding.GetEncoding(1251);
				}
				else
				{
					encoding = Encoding.GetEncoding(response.CharacterSet);
				}

				reader = new StreamReader(response.GetResponseStream(), encoding);
				html = reader.ReadToEnd();
				reader.Close();
				reader.Dispose();
				response.Close();
			}
			catch (System.Exception)
			{
				return null;
			}
			return html;
		}
	}
}