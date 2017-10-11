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

        public ModalPage(Image image)
        {
            // Create a button:
            Button btnClose = new Button { Text = "Close"};
            btnClose.Clicked += BtnClose_Clicked;

            //Label lblCar = image.
            // Create image based on incoming image
            Image imgCar = new Image {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Source= image.Source
            };
            
            Content = new StackLayout
            {
                Children = {
                    imgCar,
                    btnClose
                }
            };
        }


        private async void BtnClose_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}