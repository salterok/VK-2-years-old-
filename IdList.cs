using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK
{
	public class IdList
	{
		public List<Id> Items { get; private set; }
		public IdList(params long[] ids)
		{
			Items.AddRange(ids.Select(item => new Id(item)));
		}
		public IdList(string ids)
		{
			var items = ids.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
			if (items.Length > 0)
			{
				Items.AddRange(items.Select(item => new Id(item.Trim())));
			}
		}
		public void Add(long id)
		{
			Items.Add(new Id(id));
		}
		public void Add(string id)
		{
			Items.Add(new Id(id));
		}
	}
}
