using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE1.PilleS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        private async void btnPopupHello_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Hello there!", "Hi!");
        }

        private async void btnGoBack_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Back to Menu", "Are you sure?", "Yes", "No"))
            {
                await Navigation.PopAsync(true);
            }
        }
    }
}