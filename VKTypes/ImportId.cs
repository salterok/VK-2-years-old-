using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VK {
	public class ImportId {
		private const string NUMBER_REGEX_STRING = @"+\d{12}";
		private const string EMAIL_REGEX_STRING = @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}";
		private static Regex emailRegex = null;
		private static Regex numberRegex = null;
		private StringBuilder ids = new StringBuilder();
		public ImportId(string value) {
			_init_();
			ids.Append(value);
		}
		public ImportId() {
			_init_();
		}
		private void _init_() {
			if (emailRegex == null || numberRegex == null) {
				emailRegex = new Regex(EMAIL_REGEX_STRING, RegexOptions.Compiled);
				numberRegex = new Regex(NUMBER_REGEX_STRING, RegexOptions.Compiled);
			}
		}
		public void Add(string value) {
			if (numberRegex.IsMatch(value) || emailRegex.IsMatch(value))
				ids.AppendLine("," + value);
		}
	}
}
