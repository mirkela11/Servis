using Servis.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Odbc;
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
    /// Interaction logic for odabriTipa.xaml
    /// </summary>
    public partial class odabriTipa : Window
    {
        private BazaPodataka baza;

        private ObservableCollection<Model.Korisnik> korisnici;

        public ObservableCollection<Model.Korisnik> Korisnici
        {
            get { return korisnici; }
            set { korisnici = value; }
        }
       
        private Korisnik odabran;

        public Korisnik Odabran
        {
            get { return odabran; }
            set { odabran = value; }
        }

        public odabriTipa()
        {
            baza = new BazaPodataka();
            baza.ucitajKorisnike();
            korisnici = baza.Korisnici;
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Izaberi_Click_1(object sender, RoutedEventArgs e)
        {
            if (dgrMain.SelectedItem != null)
                odabran = (Korisnik)dgrMain.SelectedItem;
            else
                odabran = null;
            this.Close();
        }
    }
}
