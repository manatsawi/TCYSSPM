﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSPM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginScreen : ContentPage
	{
		public LoginScreen ()
		{
			InitializeComponent ();
		}
        public async void button_Clicked(object Sender, EventArgs e)
        {
            string username = Mainuser.Text;
            string pass = Mainpassword.Text;

            if (username == "admin1234" && pass == "admin1234")
            {
                var page = new MainPage();
                NavigationPage.SetHasBackButton(page, false);
                await Navigation.PushAsync(page);

            }

        }
    }
}