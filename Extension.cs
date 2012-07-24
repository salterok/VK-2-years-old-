using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace VK
{
	/// <summary>
	/// Статический класс, предоставляющий методы-расширения для внутреннего использования.
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Метод-расширение, возвращающий строку-описание из атрибута <typeparamref name="DescriptionAttribute"/>.
		/// </summary>
		/// <param name="item">Объект перечисления.</param>
		/// <returns>Возвращает описание члена перечисления или пустую строку при его отсутствии.</returns>
		//public static string GetDescriptionValue(this Enum item, string separator = ",")
		//{
		//	string description = String.Empty;
		//	Type type = item.GetType();
		//	dynamic val = Enum.ToObject(type, item);
		//	ulong itemValue = (ulong)val;
		//	if (type.GetCustomAttributes(typeof(FlagsAttribute), false).Length == 0)
		//	{
		//		FieldInfo fieldInfo = type.GetField(Enum.GetName(type, itemValue));
		//		if (fieldInfo == null)
		//		{
		//			throw new InvalidEnumArgumentException("FlagsAttribute must be attached to Enum.");
		//		}
		//		var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
		//		if (attributes.Length == 0)
		//		{
		//			return String.Empty;
		//		}
		//		return (attributes[0] as DescriptionAttribute).Description;
		//	}
		//	else
		//	{
		//		var values = Enum.GetValues(type);
		//		foreach (uint value in values)
		//		{
		//			if ((itemValue & value) == value)
		//			{
		//				if (itemValue == 0)
		//				{
		//					break;
		//				}
		//				var attributes = type.GetField(Enum.GetName(type, value)).GetCustomAttributes(typeof(DescriptionAttribute), false);
		//				itemValue &= ~value;
		//				if (attributes.Length == 0)
		//				{
		//					continue;
		//				}
		//				description += String.Format("{0}{1}", (attributes[0] as DescriptionAttribute).Description, separator);
		//			}
		//		}
		//		return description == String.Empty ? String.Empty : description.Remove(description.Length - 1);
		//	}
		//}

		public static string GetDescriptionValue(this Enum value, string separator = ",", bool i = true)
		{
			var valueAsInt = Convert.ToInt64(value, CultureInfo.InvariantCulture);
			Type type = value.GetType();
			foreach (object item in Enum.GetValues(typeof(long)))
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
					return (attributes[0] as DescriptionAttribute).Description;
				}
			}

			return string.Empty;
		}
	}
}