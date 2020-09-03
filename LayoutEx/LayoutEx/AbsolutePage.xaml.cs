using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace LayoutEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
            var layout = new AbsoluteLayout();
            Content = layout;
            
            var aquaBox = new BoxView { Color = Color.Aqua};
            var whiteBox = new BoxView { Color = Color.White };
            var gtButton = new Button { BackgroundColor = Color.Silver,Text="Get Start" };
            layout.Children.Add(aquaBox, new Rectangle(0,0,1,1),AbsoluteLayoutFlags.All);

            

            layout.Children.Add(whiteBox);
            AbsoluteLayout.SetLayoutBounds(whiteBox, new Rectangle(0.5, 0.1, 100, 100));
            AbsoluteLayout.SetLayoutFlags(whiteBox, AbsoluteLayoutFlags.PositionProportional);

            layout.Children.Add(gtButton);
            AbsoluteLayout.SetLayoutBounds(gtButton, new Rectangle(0, 1, 100, 50));
            AbsoluteLayout.SetLayoutFlags(gtButton, AbsoluteLayoutFlags.PositionProportional);
            
          
        }
    }
}