using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK
{
	public class Attachments
	{
		public List<Attachment> Items { get; private set; }
		public Attachments(params Attachment[] attachments)
		{
			if (attachments == null)
			{
				attachments = new Attachment[0];
			}
			Items = new List<Attachment>(attachments);
		}
		public void Add(Attachment attachment)
		{
			Items.Add(attachment);
		}
		public override string ToString()
		{
			return String.Join(",", Items.Select(item => item.ToString()).ToArray());
		}
	}
}
