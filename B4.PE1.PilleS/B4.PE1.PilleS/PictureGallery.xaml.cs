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
    public partial class PictureGallery : ContentPage
    {
        public PictureGallery()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped1;
            imgAston.GestureRecognizers.Add(tapGestureRecognizer);
            imgBmw.GestureRecognizers.Add(tapGestureRecognizer);
            imgJaguar.GestureRecognizers.Add(tapGestureRecognizer);

        }

        

        private async void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;
            imageSender.Opacity = 0.5;
            await Task.Delay(200);
            imageSender.Opacity = 1;
            var x = imageSender.Source.AutomationId;
            await Navigation.PushModalAsync(new ModalPage(), true);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (Image)sender;
            var x = imageSender.Source.AutomationId;
            await Navigation.PushModalAsync(new ModalPage(), true);
        }
    }
}