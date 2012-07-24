using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK
{
	public class VKResponse<T> : VKResponseBase where T : new() /*response type interface*/
	{
		public T Response { get; protected set; }


		public VKResponse(string source, bool is_xml)
			: base(source, is_xml)
		{
			if (!IsError)
			{
				if (is_xml)
				{

				}
			}
		}
	}
}
