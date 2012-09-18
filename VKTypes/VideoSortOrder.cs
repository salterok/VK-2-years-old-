using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	public enum VideoSortOrder {
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
		/// по релевантности
		/// </summary>
		[Description("2")]
		Relevance = 2
	}
}
