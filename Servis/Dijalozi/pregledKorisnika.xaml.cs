using Servis.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
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
    /// Interaction logic for pregledKorisnika.xaml
    /// </summary>
    public partial class pregledKorisnika : Window
    {
        private static pregledKorisnika instanca;
        private BazaPodataka baza;
        private ObservableCollection<Korisnik> korisnici;

        public ObservableCollection<Korisnik> Korisnici
        {
            get { return korisnici; }
            set { korisnici = value; }
        }

        public static pregledKorisnika Instanca
        {
            get { return instanca; }
        }
        public pregledKorisnika()
        {
            instanca = null;
            Korisnici = new ObservableCollection<Korisnik>();
            baza = new BazaPodataka();
            baza.ucitajKorisnike();
            korisnici = baza.Korisnici;
            this.DataContext = this;
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            string filter = textBox.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(korisnici);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Korisnik man = o as Korisnik;
                    string[] words = filter.Split(' ');
                    if (words.Contains(""))
                        words = words.Where(word => word != "").ToArray();
                    return words.Any(word => man.Ime.ToUpper().Contains(word.ToUpper()));
                };

                dgrMain.ItemsSource = korisnici;
            }
        }

        public int idx = -1;
        public Korisnik izmenjen;
        private void IzmeniBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(dgrMain.SelectedValue is Korisnik)
            {
                Korisnik k = (Korisnik)dgrMain.SelectedValue;

                var s = new izmeniKorisnika(k);
                s.ShowDialog();
                if (s.idx != -1)
                {
                    baza.Korisnici[s.idx] = s.izmenjen;
                    baza.sacuvajKorisnika();
                    baza.ucitajKorisnike();
                    korisnici = baza.Korisnici;
                    idx = s.idx;
                    izmenjen = s.izmenjen;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Niste odabrali nijedan spomenik.", "Izmena spomenika");

            }
        }

        private void ObrisiBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Korisnik k = null; 
            if (dgrMain.SelectedValue is Korisnik)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da izbrisete korisnika", "Brisanje korisnika", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        k = (Korisnik)dgrMain.SelectedValue;
                        baza.brisanjeKorisnika(k);

                        korisnici = baza.Korisnici;

                        break;
                    case MessageBoxResult.No:
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Niste odabrali korisnika za brisanje", "Brisanje korisnika");
            }
        }
    }
}
