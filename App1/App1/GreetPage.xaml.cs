using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();

            mySlider.Value = 0.1;

            switch (Device.RuntimePlatform)
            {
                case ("iOS"):
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                default:
                    break;
            }
		}

        private void Handle_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "OK");
        }

    }
}