using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VK.Authorization
{
	/// <summary>
	/// Представляет класс окна для авторизации клиента.
	/// </summary>
	internal class AuthorizationWindow : Form
	{
		private const string URL_PARAMS_REGEX = @"(?<param>(?<name>[\w]+)=(?<value>[\w\d]+))";
		private WebBrowser browser;
		private AuthorizationDetails authDetails;

		public AuthorizationWindow(ref AuthorizationDetails authorizationDetails)
		{
			authDetails = authorizationDetails;
			browser = new WebBrowser();
			this.Load += new EventHandler(this.AuthorizationWindow_Load);
		}

		private void AuthorizationWindow_Load(object sender, EventArgs e)
		{
			InitializeComponent();
			browser.Navigate(String.Format("http://api.vkontakte.ru/oauth/authorize?client_id={0}&scope={1}&display=popup&response_type=token",
							authDetails.appId, authDetails.rights));
		}

		private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			MatchCollection matches = Regex.Matches(e.Url.ToString(), URL_PARAMS_REGEX, RegexOptions.IgnoreCase);
			foreach (Match m in matches)
			{
				switch (m.Groups["name"].Value)
				{
					case "access_token":
						authDetails.SetAccessToken(m.Groups["value"].Value);
						break;
					case "user_id":
						authDetails.userId = Convert.ToInt32(m.Groups["value"].Value);
						break;
					case "expires_in":
						authDetails.expiresIn = Convert.ToInt32(m.Groups["value"].Value);
						break;
				}
			}
			if (authDetails.accessToken != String.Empty && authDetails.userId != -1 && authDetails.expiresIn != -1)
			{
				this.DialogResult = DialogResult.Yes;
				this.Close();
			}
		}

		private void InitializeComponent()
		{
			this.browser = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			//
			// browser
			//
			this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.browser.Location = new System.Drawing.Point(0, 0);
			this.browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.browser.Name = "browser";
			this.browser.Size = new System.Drawing.Size(610, 400);
			this.browser.TabIndex = 0;
			this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
			//
			// AuthorizationWindow
			//
			this.ClientSize = new System.Drawing.Size(610, 400);
			this.Controls.Add(this.browser);
			this.KeyPreview = true;
			this.Name = "AuthorizationWindow";
			this.ResumeLayout(false);
		}
	}
}