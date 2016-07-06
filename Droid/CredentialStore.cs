using System;
using LoginNavigationSample.Droid;
using Xamarin.Auth;
using Xamarin.Forms;
using System.Linq;

[assembly: Xamarin.Forms.Dependency(typeof(CredentialStore))]
namespace LoginNavigationSample.Droid
{
	public class CredentialStore : ICredentialStore
	{
		public string serviceId = "loggedInUser";

		public void Delete()
		{
			var account = AccountStore.Create(Forms.Context).FindAccountsForService(serviceId).FirstOrDefault();
			if (account != null)
			{
				AccountStore.Create(Forms.Context).Delete(account, serviceId);
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
				AccountStore.Create(Forms.Context).Save(account, serviceId);
			}
		}
	}
}

