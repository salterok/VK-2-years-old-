using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	/// <summary>
	/// падеж для склонения имени и фамилии пользователя
	/// </summary>
	public enum NameCase : byte {
		/// <summary>
		/// именительный
		/// </summary>
		[Description("nom")]
		Nom,
		/// <summary>
		/// родительный
		/// </summary>
		[Description("gen")]
		Gen,
		/// <summary>
		/// дательный
		/// </summary>
		[Description("dat")]
		Dat,
		/// <summary>
		/// винительный
		/// </summary>
		[Description("acc")]
		Acc,
		/// <summary>
		/// творительный
		/// </summary>
		[Description("ins")]
		Ins,
		/// <summary>
		/// предложный
		/// </summary>
		[Description("abl")]
		Abl
	}
}
