using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace VK
{
	/// <summary>
	/// Статический класс, предоставляющий методы-расширения для внутреннего использования.
	/// </summary>
	public static class Extensions
	{
		public static string GetDescriptionValue(this Enum value, string separator = ",", bool i = true)
		{
			var valueAsInt = Convert.ToInt64(value, CultureInfo.InvariantCulture);
			Type type = value.GetType();
			var flag = type.GetCustomAttributes(typeof(FlagsAttribute), true).Length > 0;
			var res = new List<string>();
			foreach (object item in Enum.GetValues(type))
			{
				var itemAsInt = Convert.ToInt64(item, CultureInfo.InvariantCulture);

				if (itemAsInt == (valueAsInt & itemAsInt))
				{
					FieldInfo fieldInfo = type.GetField(Enum.GetName(type, itemAsInt));
					if (fieldInfo == null)
					{
						throw new InvalidEnumArgumentException("FlagsAttribute must be attached to Enum.");
					}
					var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
					if (attributes.Length == 0)
					{
						return String.Empty;
					}
					if (flag)
						res.Add((attributes[0] as DescriptionAttribute).Description);
					else
						return (attributes[0] as DescriptionAttribute).Description;
				}
			}

			return String.Join(",", res.ToArray());
		}
	}
}