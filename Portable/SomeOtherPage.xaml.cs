using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ComicBook
{
    public partial class SomeOtherPage : ContentPage
    {
        void Back_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        public SomeOtherPage()
        {
            InitializeComponent();
        }
    }
}
