using System;
namespace LoginNavigationSample
{
	public interface ICredentialStore
	{
		void Save(string username, string password);
		void Delete();
		bool isLoggedIn();

	}
}

