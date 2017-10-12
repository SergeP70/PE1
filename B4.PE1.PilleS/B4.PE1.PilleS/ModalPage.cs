using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B4.PE1.PilleS
{
	public class ModalPage : ContentPage
	{
		public ModalPage ()
		{
        }

        public ModalPage(Image image, String brand)
        {
            
            // Create a button:
            Button btnClose = new Button { Text = "Close"};
            btnClose.Clicked += BtnClose_Clicked;

            // Create a label:
            Label lblCar = new Label
            {
                Text = "It's the logo of " + brand,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                IsVisible = true,
                TextColor = Color.Black
            };
            
            // Create image based on incoming image
            Image imgCar = new Image {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Source= image.Source
            };
            
            // All together now:
            Content = new StackLayout
            {
                Children = {
                    imgCar,
                    lblCar,
                    btnClose
                }
            };

            Label z = new Label();

        }


        private async void BtnClose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}