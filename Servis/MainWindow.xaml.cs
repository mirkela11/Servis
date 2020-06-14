using Servis.Dijalozi;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Servis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance;

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
        public static MainWindow Instance
        {
            get { return instance; }
        }

        private Korisnik k;
        private ObservableCollection<Korisnik> spList;
        private Point startPoint;
        public ObservableCollection<Korisnik> SpList
        {
            get { return spList; }
            set
            {
                if (spList != value)
                {

                    spList = value;
                    OnPropertyChanged("SpList");
                }
            }
        }

        private ObservableCollection<Vozilo> vozila;

        private string listVozila;
        public string Listavozila
        {
            get { return listVozila; }
            set
            {
                if (value != listVozila)
                {
                    listVozila = value;
                    OnPropertyChanged("Lista vozila");
                }
            }
        }

        private BazaPodataka baza;
        private Vozilo vozilo;
        public Vozilo Vozilo
        {
            get { return vozilo; }
            set { vozilo = value; }
        }

        public MainWindow()
        {
            instance = this;
            //  etikete = new ObservableCollection<Spomeni>();
            vozila = new ObservableCollection<Vozilo>();
            vozilo = new Vozilo();
            k = new Korisnik();
            baza = new BazaPodataka();
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;  //glavni prozor se prikazuje u centru
            this.DataContext = this;

            // trvKoris.Items.Refresh();
            baza.ucitajKorisnike();
            ucitajSve();
            spList = baza.Korisnici;
            baza.ucitajVozila();
            //baza.ucitajTipove();
            // tipovi = baza.Tipovi;

        }

        private void DodajK_btn_Click(object sender, RoutedEventArgs e)
        {
            var s = new korisnicixaml();
            s.ShowDialog();
            /*Spomenik m = s.m;
                        int count = baza.Spomenici.Count - 1;
                        baza.Spomenici[count] = m;
              */
            //  baza.ucitajSpomenike();
            // spList = baza.Spomenici;

        }

        private void DodajV_btn_Click(object sender, RoutedEventArgs e)
        {
            var v = new vozila();
            v.ShowDialog();
        }



        public bool IsSelected { get; private set; }

        private void ucitajSve()
        {
            foreach (Korisnik m in baza.Korisnici)
            {
                WrapPanel wp = new WrapPanel();
                wp.Orientation = Orientation.Vertical;

                TextBox ime = new TextBox();
                ime.IsEnabled = false;
                ime.Text = "Ime: " + m.Ime;
                wp.Children.Add(ime);


                TextBox prezime = new TextBox();
                prezime.IsEnabled = false;
                prezime.Text = "Prezime: " + m.Prezime;
                wp.Children.Add(prezime);


                TextBox brojTelefona = new TextBox();
                brojTelefona.IsEnabled = false;
                brojTelefona.Text = "Broj telefona: " + m.BrojTelefona;
                wp.Children.Add(brojTelefona);

                /*
                    TextBox datum = new TextBox();
                    datum.IsEnabled = false;
                    datum.Text = "Datum: " + m.Datum.ToShortDateString();
                    wp.Children.Add(datum);

                    TextBox unesco = new TextBox();
                    unesco.IsEnabled = false;
                    if (m.Unesco)
                        unesco.Text = "Na UNESCO listi: Da";
                    else
                        unesco.Text = "Na UNESCO listi: Ne";
                    wp.Children.Add(unesco);

                    TextBox obradjen = new TextBox();
                    obradjen.IsEnabled = false;
                    if (m.Obradjen)
                        obradjen.Text = "Arheoloski obradjen: Da";
                    else
                        obradjen.Text = "Arheoloski obradjen: Ne";
                    wp.Children.Add(obradjen);

                    TextBox naseljen = new TextBox();
                    naseljen.IsEnabled = false;
                    if (m.Naseljen)
                        naseljen.Text = "U naseljenom regionu: Da";
                    else
                        naseljen.Text = "U naseljenom regionu: Ne";
                    wp.Children.Add(naseljen);

                    TextBox era = new TextBox();
                    era.IsEnabled = false;
                    era.Text = "Era porekla: " + m.Era;
                    wp.Children.Add(era);

                    TextBox status = new TextBox();
                    status.IsEnabled = false;
                    status.Text = "Turisticki status: " + m.Status;
                    wp.Children.Add(status);

                    TextBox etikete = new TextBox();
                    etikete.IsEnabled = false;
                    etikete.Text = "Etikete:" + System.Environment.NewLine;
                    ListaEtiketa = "";
                    StringBuilder sb = new StringBuilder(ListaEtiketa);
                    ObservableCollection<Etiketa> list = m.Etikete;
                    foreach (Etiketa et in list)
                    {
                        sb.Append(et.Oznaka);
                        sb.Append(System.Environment.NewLine);
                    }
                    ListaEtiketa = sb.ToString();
                    etikete.Text += ListaEtiketa;
                    ListaEtiketa = "";
                    wp.Children.Add(etikete);

                    TextBox prihod = new TextBox();
                    prihod.IsEnabled = false;
                    prihod.Text = "Godisnji prihod: " + m.Prihod;
                    wp.Children.Add(prihod);


                    ToolTip tt = new ToolTip();
                    tt.Content = wp;
                    img.ToolTip = tt;
                    img.PreviewMouseLeftButtonDown += DraggedImagePreviewMouseLeftButtonDown;
                    img.MouseMove += DraggedImageMouseMove;

                    canvasMap.Children.Add(img);
                    Canvas.SetLeft(img, m.X - 20);
                    Canvas.SetTop(img, m.Y - 20);
                */
            }
        }

        private void DodajS_btn_Click(object sender, RoutedEventArgs e)
        {
            var s = new servis();
            s.ShowDialog();
        }

        private void PregledKorisnikaClick(object sender, RoutedEventArgs e)
        {
            var s = new pregledKorisnika();
            s.ShowDialog();
        }

        private void PregledVozilaClick(object sender, RoutedEventArgs e)
        {
            var s = new pregledVozila();
            s.ShowDialog();
        }
    }

}
