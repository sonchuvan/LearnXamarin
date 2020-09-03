using Poke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace poke
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var number = int.Parse(txtNumber.Text);
            var pokedex = new Pokedex();
            lblName.Text = pokedex.GetPokemonName(number);
            imgImage.Source = ImageSource.FromUri(new Uri(pokedex.GetPokemonImageUrl(number)));
        }
    }
}
