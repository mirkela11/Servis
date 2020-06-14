using Servis.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for pregledVozila.xaml
    /// </summary>
    public partial class pregledVozila : Window
    {
        private ObservableCollection<Vozilo> vozila;
        private BazaPodataka baza;
        private pregledVozila instanca;

        public ObservableCollection<Vozilo> Vozila
        {
            get { return vozila; }
            set { vozila = value; }
        }

        public pregledVozila Instanca
        {
            get { return instanca; }
        }


        public pregledVozila()
        {
            instanca = null;
            vozila = new ObservableCollection<Vozilo>();
            baza = new BazaPodataka();
            InitializeComponent();
            vozila = baza.Vozila;
            this.DataContext = this;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            System.Windows.Controls.TextBox textBox = sender as System.Windows.Controls.TextBox;
            string filter = textBox.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(vozila);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Vozilo man = o as Vozilo;
                    string[] words = filter.Split(' ');
                    if (words.Contains(""))
                        words = words.Where(word => word != "").ToArray();
                    return words.Any(word => man.RegBroj.ToUpper().Contains(word.ToUpper()));
                };

                dgrMain.ItemsSource = vozila;
            }
        }

        private void ObrisiBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Vozilo k = null;
            if (dgrMain.SelectedValue is Vozilo)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da izbrisete vozilo?", "Brisanje vozila !", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        k = (Vozilo)dgrMain.SelectedValue;
                        baza.brisanjeVozila(k);

                        vozila = baza.Vozila;

                        break;
                    case MessageBoxResult.No:
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Niste odabrali vozilo za brisanje", "Brisanje vozila");
            }
        }
    }
}
