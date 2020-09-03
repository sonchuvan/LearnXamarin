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
    public partial class AbsoluteEx2 : ContentPage
    {
        public AbsoluteEx2()
        {
            InitializeComponent();
            //img1.Source = ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/nature/7"));
            box.Opacity = 50;
        }
    }
}