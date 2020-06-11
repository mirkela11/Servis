using Servis.Model;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
    /// Interaction logic for korisnicixaml.xaml
    /// </summary>
    public partial class korisnicixaml : Window
    {
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

        public korisnicixaml()
        {
            baza = new BazaPodataka();
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sacuvaj_Click_1(object sender, RoutedEventArgs e)
        {
            Korisnik korisnik = new Korisnik(id, ime, prezime, brojTelefona);
            bool passed = baza.novKorisnik(korisnik);
            if (passed)
            {
                System.Windows.MessageBox.Show("Uspesno dodavanje novog korisnika");
                baza.sacuvajKorisnika();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Vec postoji korisnik sa tim id");
            }
        }
    }
}
