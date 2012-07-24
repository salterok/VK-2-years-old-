using System;

namespace VK.Authorization
{
	/// <summary>
	/// Представляет все необходимую для авторизации и обращения к API информацию.
	/// </summary>
	public class AuthorizationDetails
	{
		/// <summary>
		/// Уникальный идентификатор приложения.
		/// </summary>
		public int appId;

		/// <summary>
		/// Защищенный ключ.
		/// </summary>
		public string secureKey;

		/// <summary>
		/// Права, необходимые приложению.
		/// </summary>
		public AccessRights rights;

		/// <summary>
		/// Идентификатор пользователя.
		/// </summary>
		public int userId;

		/// <summary>
		/// Ключ доступа для данной сессии.
		/// </summary>
		public string accessToken;

		/// <summary>
		/// Время истечения действия ключа.
		/// </summary>
		/// <remarks>После истечения времени действия необходимо повторно авторизоватся.</remarks>
		public int expiresIn;

		/// <summary>
		/// Констуктор по умолчанию.
		/// </summary>
		public AuthorizationDetails()
		{
			appId = -1;
			secureKey = String.Empty;
			rights = AccessRights.NO_RIGHTS;
			userId = -1;
			accessToken = String.Empty;
			expiresIn = -1;
		}
	}
}