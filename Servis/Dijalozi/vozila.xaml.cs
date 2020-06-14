using Servis.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for vozila.xaml
    /// </summary>
    public partial class vozila : Window
    {
        private string markaVozila;

        public string MarkaVozila
        {
            get { return markaVozila; }
            set { markaVozila = value; }
        }

        private string modelVozila;

        public string ModelVozila
        {
            get { return modelVozila; }
            set { modelVozila = value; }
        }
        private string regBroj;
        public string RegBroj
        {
            get { return regBroj; }
            set { regBroj = value; }
        }
        private string brojSasije;
        public string BrojSasije
        {
            get { return brojSasije; }
            set { brojSasije = value; }
        }

        private Korisnik korisnik;

        public Korisnik Korisnik
        {
            get { return korisnik; }
            set
            {
                if (value != korisnik)
                {
                    korisnik = value;
                }
            }
        }

        private BazaPodataka baza;
        public vozila()
        {
            baza = new BazaPodataka();
            korisnik = new Korisnik();
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
            Vozilo v = new Vozilo(markaVozila, modelVozila, regBroj, brojSasije,korisnik);
            bool passed = baza.novoVozilo(v);
            if (passed)
            {
                baza.sacuvajVozilo();
                baza.sacuvajVoziloId();
                System.Windows.MessageBox.Show("Uspesno ste dodali novo vozilo");
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Vozilo sa tim registarskim oznakama vec postoji");
            }
        }

        private string oznakaKorisnika;

        public string OznakaKorisnika
        {
            get { return oznakaKorisnika; }
            set
            {
                if (value != oznakaKorisnika)
                {
                    oznakaKorisnika = value;
                    
                }
            }
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            odabriTipa s = new odabriTipa();
            s.ShowDialog();

            Korisnik temp = s.Odabran;
            if (temp != null)
            {
                korisnik = temp;
                oznakaKorisnika = korisnik.Ime;
                tip_textBox.Text = oznakaKorisnika;
            }
        }



    }
}
