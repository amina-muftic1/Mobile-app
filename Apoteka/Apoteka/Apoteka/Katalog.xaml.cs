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
    public partial class Katalog : ContentPage
    {
        public IList<Lijekovi> Lijek { get; private set; }
        public Katalog()
        {
            InitializeComponent();

            Lijek = new List<Lijekovi>();


            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse2.mm.bing.net/th?id=OIP.UPsNHCtx_7paSvbZqtfAYgHaHa&pid=Api&P=0&w=156&h=156",
                Naziv = "Brufen",
                Cijena = "10 KM",
                OpisLijeka = "Brufen® se koristi za kratkoročno simptomatsko ublažavanje blage do umjerene boli poput glavobolje,uključujući migrensku glavobolju/glavobolju povezanu s migrenom, neuralgiju, zubobolju, bol u mišićima i zglobovima, bol u leđima, menstrualnu bol te simptoma obične prehlade i gripe uključujući i vrućicu."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse3.mm.bing.net/th?id=OIP.2yjdEebQTqLvb7q0mCol5QHaHa&pid=Api&P=0&w=157&h=157",
                Naziv = "Angal",
                Cijena = "9 KM",
                OpisLijeka = "Angal djeluje lokalno analgetički i antimikrobno. Primjenjuje se za lokalno ublažavanje simptoma infekcije i upale ždrijela kao što su bolno gutanje ili nadražaj u odraslih, adolescenata i djece starije od 6 godina."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse1.mm.bing.net/th?id=OIP.10hypdwSpxHxbUR-z7dljgHaHa&pid=Api&P=0&w=157&h=157",
                Naziv = "GE 132 +",
                Cijena = "120 KM",
                OpisLijeka = "GE 132 je dodatak ishrani čiji sastojci pozitivno utiču na imunološki sistem čovjeka, jačajući prirodne, odbrambene sposobnosti ljudskog organizma. Djeluju antioksidativno i neutrališu dejstvo slobodnih radikala koji se dovode u vezu sa nastankom velikog broja oboljenja."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse3.mm.bing.net/th?id=OIP.OIT1JpsWyy0BvaAAfUI9CAHaEi&pid=Api&P=0&w=274&h=168",
                Naziv = "Naklofen",
                Cijena = "9 KM",
                OpisLijeka = "Naklofen gel je lek za spoljnu upotrebu sa antiinflamatornim (protivupalnim) i analgetskim dejstvom (protiv bolova). Kada aktivna supstanca (diklofenak) dospe na mesto primene, smanjuje se zapaljenski otok i poboljšava se pokretljivost."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse2.mm.bing.net/th?id=OIP.hxdUVtjT4dcABz4oG4ay5gHaGp&pid=Api&P=0&w=176&h=158",
                Naziv = "Dexiren",
                Cijena = "6 KM",
                OpisLijeka = "Dexiren sa obloženim tabletama je lijek za ublažavanje bolova. Ublažava bolove u mišićima i zglobovima, menstrualne bolove i zubobolju."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse2.mm.bing.net/th?id=OIP.Kvtr4z9teUzsQL3uHYF0QgHaHa&pid=Api&P=0&w=156&h=156",
                Naziv = "Paracetamol",
                Cijena = "8 KM",
                OpisLijeka = "Paracetamol, također poznat kao acetaminofen, je lijek koji se koristi za liječenje groznice i blage do umjerene boli. Uobičajeni nazivi robnih marki uključuju Tylenol i Panadol. U standardnoj dozi, paracetamol samo neznatno snižava tjelesnu temperaturu; inferioran je u odnosu na ibuprofen u tom pogledu, a koristi od njegove upotrebe kod groznice su nejasne. Paracetamol može ublažiti bol kod akutne blage migrene."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse3.mm.bing.net/th?id=OIP.6CIw1t4NjRNyeDl-6L0KswHaJo&pid=Api&P=0&w=122&h=158",
                Naziv = "Sumatriptan",
                Cijena = "15 KM",
                OpisLijeka = "Lek Sumatriptan sadrži supstancu sumatriptan, koja pripada grupi lekova koji se nazivaju triptani (takođe poznati kao agonisti 5 - HT receptora). Lek Sumatriptan se koristi u terapiji glavobolje koja se naziva migrena.Simptomi migrene mogu nastati usled privremenog širenja krvnih sudova glave. Lek Sumatriptan deluje tako sužava te krvne sudove.Samim tim, pomaže u ublažavanju glavobolje i ostalih simptoma prilikom migrene, kao što su mučnina, povraćanje, osetljivost na svetlost i zvuk."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse3.mm.bing.net/th?id=OIP.KJsNIpQYGnf8LSDNlbU6dAHaFb&pid=Api&P=0&w=209&h=153",
                Naziv = "Enterofuryl",
                Cijena = "7 KM",
                OpisLijeka = "Izgled kapsule: duguljaste, tvrde želatinske kapsule koje se sastoje od kape i tela žute boje, - sadržaj kapsule: granulat ili blago komprimovani granulat žute boje koji se raspada blagim pritiskom.Kao dodatak rehidrataciji, simptomatska terapija akutne dijareje, najčešće bakterijskog porekla, invazivnih simptoma(pogoršanje opšteg stanja, groznica, znakovi intoksikacije itd.Terapija ne isključuje dijetarni režim i rehidrataciju,ukoliko je neophodno. "
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse4.mm.bing.net/th?id=OIP.u_4QCaNA4ckAd0tNnlt4qwAAAA&pid=Api&P=0&w=180&h=152",
                Naziv = "Fordex",
                Cijena = "10 KM",
                OpisLijeka = "FORDEX sadrži metformin, lijek koji se primjenjuje u liječenju dijabetesa. Metformin pripada grupi lijekova koji se nazivaju bigvanidi.Inzulin je hormon koji luči žlijezda gušterača.Pomoću inzulina organizam preuzima glukozu(šećer) iz krvi.Vaš organizam koristi glukozu za proizvodnju energije ili je pohranjuje za buduće potrebe.Ako imate dijabetes,Vaša gušterača ne proizvodi dovoljnu količinu inzulina ili Vaš organizam ne može pravilno iskoristiti proizvedeni inzulin."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse3.mm.bing.net/th?id=OIP.gig3AorPUlBxet-lHiuTLQHaHa&pid=Api&P=0&w=163&h=163",
                Naziv = "Siofor",
                Cijena = "19 KM",
                OpisLijeka = "Siofor sadrži metformin, lijek za liječenje šećerne bolesti. Pripada skupini lijekova koji se zovu bigvanidi.Siofor se koristi za liječenje šećerne bolesti tipa 2 (također zvana «šećerna bolest neovisna o inzulinu») kad se samo pravilnom prehranom i tjelovježbom ne može postići odgovarajuća kontrola razine glukoze u krvi. Posebno se koristi kod bolesnika s prekomjernom tjelesnom težinom."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse3.mm.bing.net/th?id=OIP.g7fiZdZneL4bCyPtCUGxjQHaEl&pid=Api&P=0&w=255&h=158",
                Naziv = "Januvia",
                Cijena = "13.50 KM",
                OpisLijeka = "Januvia je jedan od najefikasnijih i najsigurnijih lekova koji se koristi u medicinskoj praksi za lečenje dijabetesa Lijek u svojoj strukturi je sintetski lijek iz skupine inkretena.Sami incretini su hormoni koji direktno sudjeluju u sintezi inzulina i iskorištavanju glukoze u krvi.Glavni aktivni sastojak je sitagliptin (mnn), jer su pomoćni sastojci kalcijev hidrogen fosfat, mikrokristalna celuloza, magnezijum stearat, kroskarmeloza i natrijum stearil fumarat, koji su takođe dio lijeka."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse3.mm.bing.net/th?id=OIP.MqFENte8wDsjeD67venIkQHaE8&pid=Api&P=0&w=248&h=165",
                Naziv = "Bisocor",
                Cijena = "13 KM",
                OpisLijeka = "Bisocor tablete spadaju u grupu lijekova koji se nazivaju beta-blokatori. Ovi lijekovi štite srce od pretjerane aktivnosti,što srce čini opuštenijim i smanjuje krvni pritisak.Bisoprolol fumarat se može koristiti za liječenje angine pektoris(bol u grudima uzrokovana arterija koje provode krv do srčanog mišića) ili hipertenzija(visok krvni pritisak)."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse2.mm.bing.net/th?id=OIP.p4QUD0zgltm0bl9Z-1AeCAHaHa&pid=Api&P=0&w=157&h=157",
                Naziv = "Verapamil",
                Cijena = "15 KM",
                OpisLijeka = "Lek Verapamil HF sadrži aktivnu supstancu verapamil hidrohlorid, koja pripada grupi lekova poznatoj kao blokatori kalcijumskih kanala.Blokatori kalcijumskih kanala menjaju količinu kalcijuma koji ulazi u mišićne ćelije vašeg srca i krvnih sudova.Ovo može promeniti snagu i brzinu kojom srce kuca.Takođe širi krvne sudove tako da se krv lakše doprema do telesnih organa. Na ovaj način više kiseonika dospeva do Vašeg srčanog mišića i time može da se smanji učestalost i težina napada angine pektoris."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse2.mm.bing.net/th?id=OIP.HduhIU2DGDT7vjbjdDspBwHaHa&pid=Api&P=0&w=167&h=167",
                Naziv = "Fursemid FORTE",
                Cijena = "12 KM",
                OpisLijeka = "FURSEMID FORTE tablete indicirane su u bolesnika sa znatno smanjenom glomerularnom filtracijom(glomerularna filtracija manja od 20 ml / min).Oligurija koja može napredovati do anurije i terminalna insuficijencija bubrega(stupanj prije dijalize i stupanj koji zahtjeva dijalizu), s edemom i / ili povišenim krvnim tlakom, ili kako bi se očuvala preostala diureza(učinak pojačane diureze potrebno je periodički provjeravati testom protoka urina)."
            });
            Lijek.Add(new Lijekovi
            {
                ImageURL = "https://tse1.mm.bing.net/th?id=OIP.rjykwpoxl99Nl9jV78kRNgHaE8&pid=Api&P=0&w=236&h=157",
                Naziv = "Amaryl",
                Cijena = "11 KM",
                OpisLijeka = "Amaryl je indikovan za terapiju diabetes mellitus-a tip 2, kada samo dijeta, fizička aktivnost i telesne mase,nisu dovoljni za postizanje odgovajućih rezultata"
            });
            BindingContext = this;

        }
        async private void lst_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Lijekovi selectedItem = e.SelectedItem as Lijekovi;
            await Navigation.PushAsync(new Lijek(selectedItem.Naziv, selectedItem.ImageURL, selectedItem.Cijena, selectedItem.OpisLijeka));

        }
    }
    public class Lijekovi
    {
        public string ImageURL { get; set; }
        public string Naziv { get; set; }
        public string Cijena { get; set; }
        public string OpisLijeka { get; set; }
    }
}