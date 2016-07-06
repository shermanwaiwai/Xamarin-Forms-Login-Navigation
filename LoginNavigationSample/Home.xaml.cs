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

			//If user isn't already logged in, push LoginPage on top of NavigationPage
			Navigation.PushModalAsync(new LoginPage());
			//else stay on home page
		}

		void Settings_Clicked(object sender, System.EventArgs e)
		{
			//Push settings page.  This will keep the Navigation Page structure
			//providing a back button to Home
			Navigation.PushAsync(new SettingsPage());
		}
	}
}

