using System;

namespace VK
{
	/// <summary>
	/// Определяет различные права доступа, которые может запросить приложение
	/// </summary>
	[Flags]
	public enum AccessRights
	{
		/// <summary>
		/// Указывает на отсутствие прав.
		/// </summary>
		/// <remarks>Используется как значение по-умолчанию</remarks>
		[Obsolete("Это значение предназначено для внутренней проверки. Не рекомендуется использовать")]
		NO_RIGHTS = 0,

		/// <summary>
		/// Пользователь разрешил отправлять ему уведомления.
		/// </summary>
		NOTIFY = 1,

		/// <summary>
		/// Доступ к друзьям.
		/// </summary>
		FRIENDS = 2,

		/// <summary>
		/// Доступ к фотографиям.
		/// </summary>
		PHOTOS = 4,

		/// <summary>
		/// Доступ к аудиозаписям.
		/// </summary>
		AUDIO = 8,

		/// <summary>
		/// Доступ к видеозаписям.
		/// </summary>
		VIDEO = 16,

		/// <summary>
		/// Доступ к предложениям (устаревшие методы).
		/// </summary>
		OFFERS = 32,

		/// <summary>
		/// Доступ к вопросам (устаревшие методы).
		/// </summary>
		QUESTIONS = 64,

		/// <summary>
		/// Доступ к wiki-страницам.
		/// </summary>
		PAGES = 128,

		/// <summary>
		/// Добавление ссылки на приложение в меню слева.
		/// </summary>
		LINK = 256,

		/// <summary>
		/// Доступ заметкам пользователя.
		/// </summary>
		NOTES = 2048,

		/// <summary>
		/// (для Standalone-приложений) Доступ к расширенным методам работы с сообщениями.
		/// </summary>
		MESSAGES = 4096,

		/// <summary>
		/// Доступ к обычным и расширенным методам работы со стеной.
		/// </summary>
		WALL = 8192,

		/// <summary>
		/// Доступ к документам пользователя.
		/// </summary>
		DOCS = 131072,

		/// <summary>
		/// Доступ к группам пользователя.
		/// </summary>
		GROUPS = 262144
	}

	/// <summary>
	/// Определяет группы пользователей, имеющих права доступа к контенту.
	/// </summary>
	public enum AccessGroups
	{
		/// <summary>
		/// Только руководители группы.
		/// </summary>
		ONLY_ADMINS = 0,

		/// <summary>
		/// Только участники группы.
		/// </summary>
		ONLY_GROUP_MEMBERS = 1,

		/// <summary>
		/// Все имеют доступ.
		/// </summary>
		EVERYONE = 2
	}
}