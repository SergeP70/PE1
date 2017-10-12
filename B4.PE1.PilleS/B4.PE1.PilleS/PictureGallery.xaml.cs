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

            // Adding Tap event to each image:
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
            imgAudi.GestureRecognizers.Add(tapGestureRecognizer);
            imgAston.GestureRecognizers.Add(tapGestureRecognizer);
            imgJaguar.GestureRecognizers.Add(tapGestureRecognizer);
            imgMerc.GestureRecognizers.Add(tapGestureRecognizer);
            imgHonda.GestureRecognizers.Add(tapGestureRecognizer);
            imgBmw.GestureRecognizers.Add(tapGestureRecognizer);
            imgToyota.GestureRecognizers.Add(tapGestureRecognizer);
            imgLamborghini.GestureRecognizers.Add(tapGestureRecognizer);
            imgOpel.GestureRecognizers.Add(tapGestureRecognizer);
            imgMazda.GestureRecognizers.Add(tapGestureRecognizer);
            imgFord.GestureRecognizers.Add(tapGestureRecognizer);
            imgLexus.GestureRecognizers.Add(tapGestureRecognizer);

        }



        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Image imageSender = (Image)sender;
            String carName = "";
            
            if (sender == imgAston) carName = "Aston Martin";
            if (sender == imgAudi) carName = "Audi";
            if (sender == imgBmw) carName = "BMW";
            if (sender == imgFord) carName = "Ford";
            if (sender == imgHonda) carName = "Honda";
            if (sender == imgJaguar) carName = "Jaguar";
            if (sender == imgLamborghini) carName = "Lamborghini";
            if (sender == imgLexus) carName = "Lexus";
            if (sender == imgMazda) carName = "Mazda";
            if (sender == imgMerc) carName = "Mercedes";
            if (sender == imgOpel) carName = "Opel";
            if (sender == imgToyota) carName = "Toyota";

            // Opacity trick for UI "Click-feel"
            imageSender.Opacity = 0.5;
            await Task.Delay(100);
            imageSender.Opacity = 1;
            // Send image to the ModalPage:
            await Navigation.PushModalAsync(new ModalPage(imageSender, carName), true);
        }

    }
}