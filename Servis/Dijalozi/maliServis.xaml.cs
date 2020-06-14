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
    /// Interaction logic for maliServis.xaml
    /// </summary>
    public partial class maliServis : Window
    {
        private bool filterUlja;
        private bool filterVazduha;
        private bool filterGoriva;
        private bool filterKabine;
        private string ulje;
        private int kolicina;
        public bool FilterUlja
        {
            get { return filterUlja; }
            set
            {
               
                    filterUlja = value;
               
            }
        }
        public bool FilterKabine
        {
            get { return filterKabine; }
            set
            {
                    filterKabine = value;
              
            }
        }
        public bool FilterGoriva
        {
            get { return filterGoriva; }
            set
            {
               
                    filterGoriva = value;
              
            }
        }
        public bool FilterVazduha
        {
            get { return filterVazduha; }
            set
            {
             
                    filterVazduha = value;

            }
        }
        public string Ulje
        {
            get { return ulje; }
            set
            {
         
                    ulje = value;

             
            }
        }
        public int Kolicina
        {
            get { return kolicina; }
            set
            {
               
                    kolicina = value;
            }
        }
        private BazaPodataka baza;
        public maliServis()
        {

            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void SacuvajClick(object sender, RoutedEventArgs e)
        {/*
            MaliServis ms = new MaliServis(filterUlja, filterVazduha, filterKabine, filterGoriva, ulje, kolicina);
            bool passed = baza.novServis(ms);
            if (passed)
            {
                baza.sacuvajVozilo();
                System.Windows.MessageBox.Show("Uspesno ste dodali novo vozilo");
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Vozilo sa tim registarskim oznakama vec postoji");
            }*/
        }
    }
}
