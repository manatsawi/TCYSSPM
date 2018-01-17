using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using Newtonsoft.Json.Linq;

namespace SSPM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public async void button_Clicked(object Sender, EventArgs e)
        {
            string username = Mainuser.Text;
            string pass = Mainpassword.Text;
            var action = await DisplayAlert("Notification", "คุณต้องการเข้าสู่ระบบใช่หรือไม่", "YES", "NO");
            if (action)
            {
                if (username == "1234" && pass == "1234")
                { 
                    var page = new TabbedPage
                    {
                        BackgroundColor = Color.FromHex("#F5F3F6"),
                        Children =
                        {
                            new InProcessProjectScreen(),
                            new SuccessProjectScreen()
                        }

                    };


                    NavigationPage.SetHasBackButton(page, false);
                    await Navigation.PushAsync(page);
                 }
                else
                {
                    await DisplayAlert("Notification", "เข้าสู่ระบบล้มเหลว! Username หรือ Password ผิด", "Cancle");
                }

            }
            else
            {
                return;
            }
        }


        /*
        public async void button_Clicked(object Sender, EventArgs e)
        {
            string username = Mainuser.Text;
            string pass = Mainpassword.Text;
            var action = await DisplayAlert("Notification", "คุณต้องการเข้าสู่ระบบใช่หรือไม่", "YES", "NO");
            if (action)
            {


                string json = await PostRequest(username, pass);
                JObject obj = JObject.Parse(json);
                bool check = (bool)obj["success"];
                if (check == true)
                {

                    var page = new TabbedPage
                    {
                        BackgroundColor = Color.FromHex("#F5F3F6"),
                        Children =
                        {
                            new InProcessProjectScreen(),
                            new SuccessProjectScreen(),
                            new Setting(),
                            new Dummy()

                        }

                    };


                    NavigationPage.SetHasBackButton(page, false);
                    await Navigation.PushAsync(page);
                }
                else
                {
                    await DisplayAlert("Notification","เข้าสู่ระบบล้มเหลว! Username หรือ Password ผิด","Cancle");
                }

            }
            else
            {
                return;
            }
        }


        public async Task<string>PostRequest(string username, string password)
        {
            try
            {
                // This is the postdata
                var postData = new List<KeyValuePair<string, string>>(2);
                postData.Add(new KeyValuePair<string, string>("user", username));
                postData.Add(new KeyValuePair<string, string>("pass", password));

                HttpContent content = new FormUrlEncodedContent(postData);

                using (var client = new HttpClient())
                {
                    client.Timeout = new TimeSpan(0, 0, 15);
                    using (var response = await client.PostAsync("http://192.168.88.166:52653/Account/check", content))
                    {
                        if (((int)response.StatusCode >= 200) && ((int)response.StatusCode <= 299))
                        {
                            using (var responseContent = response.Content)
                            {
                                string result = await responseContent.ReadAsStringAsync();
                                Console.WriteLine(result);
                                return result;
                            }
                        }
                        else
                        {
                            return "error " + Convert.ToString(response.StatusCode);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return Convert.ToString(ex);
            }

        }*/
    }
}