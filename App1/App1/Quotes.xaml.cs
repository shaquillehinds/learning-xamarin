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
	public partial class Quotes : ContentPage
	{
        public string[] myQuotes = new []{ "Testing","Consentwise","Xamarin"};
        public int iterationState = 0;
		public Quotes ()
		{
			InitializeComponent ();
            quotes.Text = myQuotes[0];
            fontSlider.Value = 17;
		}

        private void Handle_Quotes(object sender, EventArgs e)
        {
            if (iterationState < 2) { iterationState++; }
            else { iterationState = 0; }
            quotes.Text = myQuotes[iterationState];
        }
	}
}