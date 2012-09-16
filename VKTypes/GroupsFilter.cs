using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	public enum GroupsFilter {
		[Description("admin")]
		Admin,
		[Description("groups")]
		Groups,
		[Description("publics")]
		Publics,
		[Description("events")]
		Events
	}
}
