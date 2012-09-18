using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	public enum NotSure {
		/// <summary>
		/// Возможно пойду
		/// </summary>
		[Description("1")]
		Maybe = 1,
		/// <summary>
		/// Точно пойду
		/// </summary>
		[Description("0")]
		Exactly = 0
	}
}
