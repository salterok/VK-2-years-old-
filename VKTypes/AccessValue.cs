using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VK {
	public enum AccessValue {
		[Description("0")]
		GroupLeader = 0,
		[Description("1")]
		GroupMember = 1,
		[Description("2")]
		All = 2
	}
}
