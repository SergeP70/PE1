using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace B4.PE1.PilleS
{
	public class ModalPage : ContentPage
	{
		public ModalPage ()
		{
            Button btnClose = new Button { Text = "Close" };
            btnClose.Clicked += BtnClose_Clicked;
            Image imgCar = new Image { Aspect = Aspect.AspectFit };
            imgCar.Source = ImageSource.FromResource("B4.PE1.PilleS.images.audi.png");


            Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin Forms!" },
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