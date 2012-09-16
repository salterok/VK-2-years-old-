using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	[Flags]
	public enum SuggestionType {
		/// <summary>
		///  пользователи, с которыми много общих друзей
		/// </summary>
		[Description("mutual")]
		Mutual,
		/// <summary>
		/// пользователи найденные благодаря методу <see cref="Account.ImportContacts"/>
		/// </summary>
		[Description("contacts")]
		Contacts,
		/// <summary>
		/// пользователи, которые импортировали те же контакты что и текущий пользователь, используя метод <see cref="Account.ImportContacts"/>
		/// </summary>
		[Description("mutual_contacts")]
		MutualContacts
	}
}
