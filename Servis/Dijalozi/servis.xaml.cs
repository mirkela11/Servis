using Servis.Model;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for servis.xaml
    /// </summary>
    public partial class servis : Window
    {
        private Korisnik korisnik;
        public Korisnik Korisnik
        {
            get { return korisnik; }
            set { korisnik = value; }
        }

        private Vozilo vozilo;
        public Vozilo Vozilo
        {
            get { return vozilo; }
            set { vozilo = value; }
        }

        private MaliServis ms;
        public MaliServis MaliServis
        {
            get { return ms; }
            set { ms = value; }
        }

        private int predjenaKilometraza;
        public int PredjenaKilometraza
        {
            get { return predjenaKilometraza; }
            set { predjenaKilometraza = value; }
        }

        private BazaPodataka baza;
        public servis()
        {
            baza = new BazaPodataka();
            korisnik = new Korisnik();
            vozilo = new Vozilo();
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
            Servisi s = new Servisi(korisnik, vozilo, ms, predjenaKilometraza);
            bool passed = baza.novServis(s);
            if (passed)
            {
                baza.sacuvajServis();
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

        private string oznakaVozila;

        public string OznakaVozila
        {
            get { return oznakaVozila; }
            set
            {
                if (value != oznakaVozila)
                {
                    oznakaVozila = value;

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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            odabirVozila s = new odabirVozila();
            s.ShowDialog();

            Vozilo temp = s.Odabran;
            if (temp != null)
            {
                vozilo = temp;
                oznakaVozila = vozilo.MarkaVozila;
                modelVozila_textBox.Text = oznakaVozila;
            }
        }

        private void MaliServisClick(object sender, RoutedEventArgs e)
        {
            maliServis ms = new maliServis();
            ms.ShowDialog();
        }
    }
}
