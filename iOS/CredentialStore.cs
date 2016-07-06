using System;
using Xamarin.Auth;
using System.Linq;
using LoginNavigationSample.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(CredentialStore))]
namespace LoginNavigationSample.iOS
{
	public class CredentialStore : ICredentialStore
	{
		public string serviceId = "loggedInUser";

		public void Delete()
		{
			var account = AccountStore.Create().FindAccountsForService(serviceId).FirstOrDefault();
			if (account != null)
			{
				AccountStore.Create().Delete(account, serviceId);
			}
		}

		public bool isLoggedIn()
		{
			var account = AccountStore.Create().FindAccountsForService(serviceId).FirstOrDefault();
			return (account != null) ? true : false;
		}

		public void Save(string username, string password)
		{
			if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
			{
				Account account = new Account
				{
					Username = username
				};
				account.Properties.Add("Password", password);
				AccountStore.Create().Save(account, serviceId);
			}
		}
	}
}

