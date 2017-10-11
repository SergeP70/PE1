using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B4.PE1.PilleS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            var msgService = DependencyService.Get<IMessageService>();
            lblWelcome.Text = "on " + msgService.GetWelcomeMessage();
        }

        private async void btnAlertPage_Clicked(object sender, EventArgs e)
        {
            // Navigation to Alert Page
            await Navigation.PushAsync(new AlertPage());
        }

        private async void btnPictureGallery_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new NavigationPage(new PictureGallery()));
            await Navigation.PushAsync(new PictureGallery());
        }

        private void btnWikiPage_Clicked(object sender, EventArgs e)
        {

        }
    }
}
