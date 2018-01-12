using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SSPM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterScreen : ContentPage
	{
		public RegisterScreen ()
		{
			InitializeComponent ();
		}
        public async void button_Clicked(object Sender, EventArgs e)
        {
            string username = Mainuser.Text;
            string pass = Mainpassword.Text;
            /*
            string firstname = Mainfirstname.Text;
            string lastname = Mainlastname.Text;
            string job = Mainjob.Text;
            string rule = Mainrule.Text;*/

            var page = new LoginScreen();
            NavigationPage.SetHasBackButton(page, false);
            await Navigation.PushAsync(page);

          

        }
    }
}