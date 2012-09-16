using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VK {
	public enum AudioSortOrder {
		/// <summary>
		/// по дате добавления
		/// </summary>
		Date = 0,
		/// <summary>
		/// по длительности аудиозаписи
		/// </summary>
		Duration = 1,
		/// <summary>
		/// по популярности
		/// </summary>
		Popularity = 2
	}
}
