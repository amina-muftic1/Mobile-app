using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apoteka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lokacije : ContentPage
    {
        public Lokacije()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            var location = new Location(43.866237, 18.398630);
            var options = new MapLaunchOptions { Name = "Apoteka PharC" };
            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                //Nije dostupno
            }
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            var location2 = new Location(43.8450612, 18.3453912);
            var options2 = new MapLaunchOptions { Name = "Apoteka PharC" };
            try
            {
                await Map.OpenAsync(location2, options2);
            }
            catch (Exception ex2)
            {
                //Nije dostupno
            }
        }


    }
}