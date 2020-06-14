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
    /// Interaction logic for odabirVozila.xaml
    /// </summary>
    public partial class odabirVozila : Window
    {
        private BazaPodataka baza;
        private Korisnik korisnik;
        private Vozilo vozilo;

        private odabriTipa ot;

        private ObservableCollection<Model.Vozilo> vozila;
        public ObservableCollection<Model.Vozilo> Vozila
        {
            get
            {
                return vozila;
            }
            set
            {
                vozila = value;
            }
        }

        private Vozilo odabran;
        public Vozilo Odabran
        {
            get { return odabran; }
            set
            {
                odabran = value;
            }
        }




        public odabirVozila()
        {
            baza = new BazaPodataka();
            baza.ucitajVozila();
            vozila = baza.Vozila;
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
                odabran = (Vozilo)dgrMain.SelectedItem;
            else
                odabran = null;
            this.Close();
        }
    }
}
