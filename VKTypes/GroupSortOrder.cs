using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	public enum GroupSortOrder {
		[Description("id_asc")]
		IdAsc,
		[Description("id_desc")]
		IdDesc,
		[Description("time_asc")]
		TimeAsc,
		[Description("time_desc")]
		TimeDesc
	}
}
