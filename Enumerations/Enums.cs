using System.ComponentModel;

namespace VK
{
	/// <summary>
	/// падеж для склонения имени и фамилии пользователя
	/// </summary>
	public enum NameCase : byte
	{
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

	/// <summary>
	/// определяет типы сообщений на стене
	/// </summary>
	public enum WallFilter : byte
	{
		/// <summary>
		/// сообщения на стене от ее владельца
		/// </summary>
		[Description("owner")]
		Owner,

		/// <summary>
		/// сообщения на стене не от ее владельца
		/// </summary>
		[Description("other")]
		Others,

		/// <summary>
		/// все сообщения на стене
		/// </summary>
		[Description("all")]
		All
	}

	/// <summary>
	/// порядок сортировки
	/// </summary>
	public enum SortOrder : byte
	{
		/// <summary>
		/// хронологический
		/// </summary>
		[Description("asc")]
		Asc,

		/// <summary>
		/// антихронологический(обратный)
		/// </summary>
		[Description("desc")]
		Desc
	}
}