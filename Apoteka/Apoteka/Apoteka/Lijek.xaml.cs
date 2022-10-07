using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apoteka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lijek : ContentPage
    {
        public Lijek(string Naziv, string ImageURL, string Cijena, string OpisLijeka)
        {
            InitializeComponent();

            NazivLijeka.Text = Naziv;
            CijenaLijeka.Text = CijenaLijeka.Text + Cijena;
            SlikaLijeka.Source = ImageURL;
            OpisLijekova.Text = OpisLijekova.Text + OpisLijeka;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Naruci());
        }
    }

}