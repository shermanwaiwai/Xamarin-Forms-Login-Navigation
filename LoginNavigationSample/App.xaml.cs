using Xamarin.Forms;

namespace LoginNavigationSample
{
	public partial class App : Application
	{
		private bool isLoggedin = false;
		public App()
		{
			InitializeComponent();

			if (isLoggedin)
			{
				//Already logged in, go to home
				MainPage = new NavigationPage(new Home());
			}
			else {
				//not logged in, go to LoginPage
				MainPage = new LoginPage();
			}



		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

