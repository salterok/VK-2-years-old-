using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	public enum AudioSortOrder {
		/// <summary>
		/// по дате добавления
		/// </summary>
		[Description("0")]
		Date = 0,
		/// <summary>
		/// по длительности аудиозаписи
		/// </summary>
		[Description("1")]
		Duration = 1,
		/// <summary>
		/// по популярности
		/// </summary>
		[Description("2")]
		Popularity = 2
	}
}
