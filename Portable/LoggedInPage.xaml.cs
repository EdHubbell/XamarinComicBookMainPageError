using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ComicBook
{
    public partial class LoggedInPage : ContentPage
    {

		public LoggedInPage()
		{
			InitializeComponent();
   		}

		public LoggedInPage(bool loggedIn)
		{
			InitializeComponent();

            btnSecureOtherPage.IsEnabled = loggedIn;

            lblBug.IsVisible = loggedIn;
		}

		void HandleOtherPage_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new SomeOtherPage());
        }

		void Back_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

    }
}
