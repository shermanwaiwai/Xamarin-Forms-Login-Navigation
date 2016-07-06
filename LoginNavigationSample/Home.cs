using System;

using Xamarin.Forms;

namespace LoginNavigationSample
{
	public class Home : ContentPage
	{
		public Home()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


