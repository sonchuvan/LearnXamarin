using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridEx : ContentPage
    {
        public GridEx()
        {
            InitializeComponent();
        }

        private String num = ""; 
        private void Button_Clicked(object sender, EventArgs e)
        {
            num += btn1.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            num += btn2.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            num += btn3.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            num += btn4.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            num += btn5.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            num += btn6.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            num += btn7.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            num += btn8.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            num += btn9.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            num += btn0.Text;
            lbl1.Text = num;
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            num = "";
            lbl1.Text = "";
        }
    }
}