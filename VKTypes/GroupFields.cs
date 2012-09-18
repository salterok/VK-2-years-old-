using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	[Flags]
	public enum GroupFields {
		/// <summary>
		/// Возвращается id города, указанного в информации о сообществе
		/// </summary>
		[Description("city")]
		City,
		/// <summary>
		/// Возвращается id страны, указанной в информации о сообществе
		/// </summary>
		[Description("country")]
		Country,
		/// <summary>
		/// Возвращается место, указанное в информации о группе
		/// </summary>
		[Description("place")]
		Place,
		/// <summary>
		/// Возвращается описание сообщества
		/// </summary>
		[Description("description")]
		Description,
		/// <summary>
		/// Возвращается название главной вики-страницы сообщества
		/// </summary>
		[Description("wiki_page")]
		WikiPage,
		/// <summary>
		/// Возвращается количество участников сообщества
		/// </summary>
		[Description("members_count")]
		MembersCount,
		/// <summary>
		/// Возвращается объект counters содержащий счётчики сообщества
		/// </summary>
		[Description("counters")]
		Counters,
		/// <summary>
		/// Cодержит время начала встречи в формате unixtime. Возвращаются только для встреч
		/// </summary>
		[Description("start_date")]
		StartDate,
		/// <summary>
		/// Cодержит время окончания встречи в формате unixtime. Возвращаются только для встреч
		/// </summary>
		[Description("end_date")]
		EndDate
	}
}
