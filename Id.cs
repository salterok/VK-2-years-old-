using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK
{
	public class Id
	{
		public object BaseId { get; protected set; }
		public Id(long id)
		{
			BaseId = id;
		}
		public Id(string id)
		{
			BaseId = id;
		}
		public virtual string Value
		{
			get
			{
				return BaseId.ToString();
			}
		}
	}
}
