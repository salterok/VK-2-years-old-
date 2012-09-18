using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	[Flags]
	public enum MessageFilter {
		/// <summary>
		/// только непрочитанные
		/// </summary>
		[Description("1")]
		Unread = 1,
		/// <summary>
		/// не из чата
		/// </summary>
		[Description("2")]
		NotFromChat = 2,
		/// <summary>
		/// сообщения от друзей
		/// </summary>
		[Description("4")]
		FromFriends = 4
	}
}
