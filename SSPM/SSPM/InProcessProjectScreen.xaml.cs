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
	public partial class InProcessProjectScreen : ContentPage
	{
        public InProcessProjectScreen()
        {
            InitializeComponent();

            var dummyData = new List<string>();
            dummyData.Add("Temp Project 1");
            dummyData.Add("Temp Project 2");
            dummyData.Add("Temp Project 3");
            dummyData.Add("Temp Project 4");
            dummyData.Add("Nut DavMobile");

            mListView.ItemsSource = dummyData;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            await Navigation.PushAsync(new Page1());
        }
    }
}