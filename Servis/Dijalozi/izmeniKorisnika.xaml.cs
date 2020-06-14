using Servis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Servis.Dijalozi
{
    /// <summary>
    /// Interaction logic for izmeniKorisnika.xaml
    /// </summary>
    public partial class izmeniKorisnika : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }

        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private string brojTelefona;
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
        }
        private BazaPodataka baza;
        private Korisnik selektovan;
        public izmeniKorisnika(Korisnik k)
        {
            baza = new BazaPodataka();
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.DataContext = this;
            selektovan = k;
            Id = k.Id;
            Ime = k.Ime;
            Prezime = k.Prezime;
            BrojTelefona = k.BrojTelefona;
        }

        public int idx = -1;
        public Korisnik izmenjen;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sacuvaj_Click_1(object sender, RoutedEventArgs e)
        {
            izmenjen = new Korisnik(id, ime, prezime, brojTelefona);

            baza.ucitajKorisnike();
            idx = 0;
            foreach(Korisnik k in baza.Korisnici)
            {
                if (k.Ime == izmenjen.Ime)
                    break;
                idx++;
            }
            baza.Korisnici[idx] = izmenjen;
            baza.sacuvajKorisnika();

            System.Windows.MessageBox.Show("Uspešna izmena korisnika!", "Izmena korisnika");
            this.Close();
        }
    }
}
