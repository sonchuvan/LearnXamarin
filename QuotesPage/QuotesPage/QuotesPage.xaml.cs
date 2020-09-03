using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        
        public QuotesPage()
        {
            InitializeComponent();

            lbl2.Text = quotes[count];
        }
        private String[] quotes =
        {
            "1 2 3 4 5","6,7,8,9","10,11,12,13","14,15,16,17"
        };
        private int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            if (count > quotes.Length-1)
            {
                count = 0;
            }
            lbl2.Text = quotes[count];
        }

        private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (slider1.Value < 10) {
                box1.BackgroundColor = Xamarin.Forms.Color.FromHex("#00" + (int)(slider1.Value));
            }
            else if (slider1.Value < 100) {
                box1.BackgroundColor = Xamarin.Forms.Color.FromHex("#0" + (int)(slider1.Value));
            }
            else
            box1.BackgroundColor = Xamarin.Forms.Color.FromHex("#"+(int)(slider1.Value));
        }
    }
}