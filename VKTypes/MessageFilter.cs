using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK {
	[Flags]
	public enum MessageFilter {
		/// <summary>
		/// только непрочитанные
		/// </summary>
		Unread = 1,
		/// <summary>
		/// не из чата
		/// </summary>
		NotFromChat = 2,
		/// <summary>
		/// сообщения от друзей
		/// </summary>
		FromFriends = 4
	}
}
