using System;

namespace VK.Authorization
{
	/// <summary>
	/// Представляет все необходимую для авторизации и обращения к API информацию.
	/// </summary>
	[Serializable]
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

		public DateTime issuedTime;

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
			issuedTime = DateTime.MinValue;
		}

		public bool IsEmpty() {
			return this.appId < 0 || this.rights == AccessRights.NO_RIGHTS;
		}

		public bool IsValid() {
			return !String.IsNullOrEmpty(accessToken) && issuedTime != DateTime.Now && issuedTime.AddSeconds(expiresIn) > DateTime.Now;
		}

		public void SetAccessToken(string token) {
			this.issuedTime = DateTime.Now;
			this.accessToken = token;
		}

		public AuthorizationDetails GetCleared(bool keepUser = true) {
			return new AuthorizationDetails() {
				appId = this.appId,
				rights = this.rights,
				userId = keepUser ? this.userId : -1
			};
		}
	}
}