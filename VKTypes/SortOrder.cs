using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	/// <summary>
	/// порядок сортировки
	/// </summary>
	public enum SortOrder : byte {
		/// <summary>
		/// хронологический
		/// </summary>
		[Description("asc")]
		Asc,
		/// <summary>
		/// антихронологический(обратный)
		/// </summary>
		[Description("desc")]
		Desc
	}
}
