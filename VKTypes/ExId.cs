using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK
{
	public class ExId : Id
	{
		public long ExtendId { get; protected set; }
		public ExId(long baseId, long extendId)
			: base(baseId)
		{
			ExtendId = extendId;
		}
		public ExId(string id)
			: base(0)
		{
			var val = id.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
			if (val.Length == 2)
			{
				try
				{
					var idValue = long.Parse(val[0]);
					ExtendId = long.Parse(val[1]);
					base.BaseId = idValue;
				}
				catch {}
			}
		}
		public override string Value
		{
			get
			{
				return String.Format("{0}_{1}", BaseId, ExtendId);
			}
		}
	}
}
