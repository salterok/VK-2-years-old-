using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK {
	[Flags]
	public enum GroupFields {
		/// <summary>
		/// Возвращается id города, указанного в информации о сообществе
		/// </summary>
		City,
		/// <summary>
		/// Возвращается id страны, указанной в информации о сообществе
		/// </summary>
		Country,
		/// <summary>
		/// Возвращается место, указанное в информации о группе
		/// </summary>
		Place,
		/// <summary>
		/// Возвращается описание сообщества
		/// </summary>
		Description,
		/// <summary>
		/// Возвращается название главной вики-страницы сообщества
		/// </summary>
		WikiPage,
		/// <summary>
		/// Возвращается количество участников сообщества
		/// </summary>
		MembersCount,
		/// <summary>
		/// Возвращается объект counters содержащий счётчики сообщества
		/// </summary>
		Counters,
		/// <summary>
		/// Cодержит время начала встречи в формате unixtime. Возвращаются только для встреч
		/// </summary>
		StartDate,
		/// <summary>
		/// Cодержит время окончания встречи в формате unixtime. Возвращаются только для встреч
		/// </summary>
		EndDate
	}
}
