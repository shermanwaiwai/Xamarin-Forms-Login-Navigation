using Xamarin.Auth;
using Xamarin.Forms;

namespace LoginNavigationSample
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		void Login_Clicked(object sender, System.EventArgs e)
		{
			string username = usernameEntry.Text.ToLower();
			string password = passwordEntry.Text.ToLower();
			//Simulate Login
			if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
			{
				if (username.Equals("username")&& password.Equals("password"))
				{
					//Save user credentials
					DependencyService.Get<ICredentialStore>().Save(username, password);

					//Navigate to Home
					App.Current.MainPage = new NavigationPage(new Home());
				}
				else {
					//Login Failed
					DisplayAlert("Login Fail", "Please recheck your credentials", "Ok");
				}
			}
			else {
				DisplayAlert("Login Fail", "Please make sure all fields are complete", "Ok");
			}

		}
	}
}

