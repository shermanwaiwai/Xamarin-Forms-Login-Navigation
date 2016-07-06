using Xamarin.Forms;

namespace LoginNavigationSample
{
	public partial class App : Application
	{
		private bool isLoggedIn = false;
		public App()
		{
			InitializeComponent();

			if (isLoggedIn){
				MainPage = new NavigationPage(new Home());
			}
			else {
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

