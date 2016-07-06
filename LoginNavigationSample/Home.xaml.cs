using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginNavigationSample
{
	public partial class Home : ContentPage
	{
		public Home()
		{
			InitializeComponent();
		}

		void Settings_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new SettingsPage());
		}

		void Logout_Clicked(object sender, System.EventArgs e)
		{
			//Remove user from cache
			DependencyService.Get<ICredentialStore>().Delete();
			//Navigate back to LoginPage
			App.Current.MainPage = new LoginPage();
		}



	}
}

