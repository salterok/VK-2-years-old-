using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK.VKTypes {
	public enum NewsFilter {
		/// <summary>
		/// новые записи со стен
		/// </summary>
		[Description("post")]
		Post,
		/// <summary>
		/// новые фотографии
		/// </summary>
		[Description("photo")]
		Photo,
		/// <summary>
		/// новые отметки на фотографиях
		/// </summary>
		[Description("photo_tag")]
		PhotoTag,
		/// <summary>
		/// новые друзья
		/// </summary>
		[Description("friend")]
		Friend,
		/// <summary>
		/// новые заметки
		/// </summary>
		[Description("note")]
		Note
	}
}
