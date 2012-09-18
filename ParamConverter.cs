using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Globalization;

namespace VK {
	internal static class ParamConverter {
		public static string Convert(object obj) {
			if (obj is Enum)
				return ConvertEnum(obj as Enum);
			return obj.ToString();
		}

		private static string ConvertEnum(Enum p) {
			return p.GetDescriptionValue(",");
		}
	}
}
