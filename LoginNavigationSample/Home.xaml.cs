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
			Navigation.PushModalAsync(new LoginPage());
		}

		void Settings_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new SettingsPage());
		}
	}
}

