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
			//Simulate Login
			if (!string.IsNullOrEmpty(usernameEntry.Text) &&
			    !string.IsNullOrEmpty(passwordEntry.Text))
			{
				if (usernameEntry.Text.ToLower().Equals("username")
				    && passwordEntry.Text.ToLower().Equals("password"))
				{
					//Login Successful
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

