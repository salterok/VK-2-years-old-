using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK
{
	/// <summary>
	/// определяет типы сообщений на стене
	/// </summary>
	public enum WallFilter : byte {
		/// <summary>
		/// сообщения на стене от ее владельца
		/// </summary>
		[Description("owner")]
		Owner,

		/// <summary>
		/// сообщения на стене не от ее владельца
		/// </summary>
		[Description("other")]
		Others,

		/// <summary>
		/// все сообщения на стене
		/// </summary>
		[Description("all")]
		All
	}
}
