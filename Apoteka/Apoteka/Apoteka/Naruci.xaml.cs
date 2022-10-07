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
    public partial class Naruci : ContentPage
    {
        public Naruci()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            if (ime.Text == null || prezime.Text == null || brojTelefona.Text == null || adresa.Text == null)
            {
                await DisplayAlert("Upozorenje", "Niste popunili prazna polja.Pokušajte ponovo!", "OK");
            }
            else
            {
                await DisplayAlert("Napomena", "Vaša narudžba je uspješno obrađena!", "OK");
            }

        }
    }
}