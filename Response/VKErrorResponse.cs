using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK
{
	public struct VKErrorResponse
	{
		public int Code { get; internal set; }
		public string Message { get; internal set; }
		public KeyValuePair<string, string>[] RequestParams { get; internal set; }
	}
}
