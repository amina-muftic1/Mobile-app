using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Apoteka
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Btn_pocetna_stranica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PocetnaStranica());
        }
    }
}
