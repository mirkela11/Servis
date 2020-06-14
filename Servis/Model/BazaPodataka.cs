using Newtonsoft.Json;
using Servis.Dijalozi;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Ports;

namespace Servis.Model
{
    class BazaPodataka
    {
        private ObservableCollection<Korisnik> korisnici = new ObservableCollection<Korisnik>();
        private ObservableCollection<Vozilo> vozila = new ObservableCollection<Vozilo>();
        private ObservableCollection<Servisi> servisi = new ObservableCollection<Servisi>();
        
        private Vozilo vozilo;
        private odabriTipa ot;

        private string pathKorisnik = null;
        private string pathVozilo = null;
        private string pathServis = null;
        private string pathVoziloID = null;
       // private string pathVoziloIdKorisnika = null;
        //string korisnik = 

        public BazaPodataka()
        {

            pathKorisnik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "korisnik.txt");
            pathVozilo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vozilo.txt");
            pathServis = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servis.txt");
            pathVoziloID = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "voziloID.txt");

            /*
            foreach (Vozilo v in vozila)
            {
                if (ot.Odabran.Ime.Equals(v.Korisnik.Ime))
                {
                    pathVoziloIdKorisnika = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "voziloID.txt");

                }

            }
            */
            ucitajKorisnike();
            ucitajVozila();
            ucitajServise();
            //ucitajVozilaZaKorisnike();
            sacuvajKorisnika();
        }

            


        public void ucitajKorisnike()
        {

            if (File.Exists(pathKorisnik))
            {

                using (StreamReader reader = File.OpenText(pathKorisnik))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    korisnici = (ObservableCollection<Korisnik>)serializer.Deserialize(reader, typeof(ObservableCollection<Korisnik>));
                }
            }
            else
            {
                korisnici = new ObservableCollection<Korisnik>();
            }


        }


        public void ucitajVozila()
        {


            if (File.Exists(pathVozilo))
            {

                using (StreamReader reader = File.OpenText(pathVozilo))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    vozila = (ObservableCollection<Vozilo>)serializer.Deserialize(reader, typeof(ObservableCollection<Vozilo>));
                }

            }
            else
            {
                vozila = new ObservableCollection<Vozilo>();
            }



        }
        /*public void ucitajVozilaZaKorisnike()
        {


            if (File.Exists(pathVoziloIdKorisnika))
            {

                using (StreamReader reader = File.OpenText(pathVoziloIdKorisnika))
                {
                   
                            JsonSerializer serializer = new JsonSerializer();
                            vozila = (ObservableCollection<Vozilo>)serializer.Deserialize(reader, typeof(ObservableCollection<Vozilo>));

                }

            }
            else
            {
                vozila = new ObservableCollection<Vozilo>();
            }



        }
       */
        public void ucitajServise()
        {


            if (File.Exists(pathServis))
            {

                using (StreamReader reader = File.OpenText(pathServis))
                {
                    JsonSerializer serializer = new JsonSerializer();
                     servisi = (ObservableCollection<Servisi>)serializer.Deserialize(reader, typeof(ObservableCollection<Servisi>));
                }

            }
            else
            {
                servisi = new ObservableCollection<Servisi>();
            }



        }


        public void save()
        {

            using (StreamWriter writer = File.CreateText(pathKorisnik))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, korisnici);
                writer.Close();
            }

            using (StreamWriter writer = File.CreateText(pathVozilo))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, vozila);
                writer.Close();
            }

            using (StreamWriter writer = File.CreateText(pathServis))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, servisi);
                writer.Close();
            }

            using (StreamWriter writer = File.CreateText(pathVoziloID))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, vozila);
                writer.Close();
            }

        }


        public void sacuvajKorisnika()
        {
            using (StreamWriter writer = File.CreateText(pathKorisnik))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, korisnici);
                writer.Close();
            }


        }



        public void sacuvajVozilo()
        {
            using (StreamWriter writer = File.CreateText(pathVozilo))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, vozila);
                writer.Close();
            }


        }
        public void sacuvajVoziloId()
        {
            using (StreamWriter writer = File.CreateText(pathVoziloID))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, vozila);
                writer.Close();
            }


        }

        public void sacuvajServis()
        {
            using (StreamWriter writer = File.CreateText(pathServis))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, servisi);
                writer.Close();
            }


        }


        public bool novKorisnik(Korisnik k)
        {
            foreach (Korisnik k1 in korisnici)
            {
                if (k1.Id == k.Id)
                {

                    return false;
                }
            }
            korisnici.Add(k);
            sacuvajKorisnika();

            return true;
        }


        public bool novoVozilo(Vozilo v)
        {
            foreach (Vozilo v1 in vozila)
            {
                if (v1.RegBroj.Equals(v.RegBroj) )
                {

                    return false;
                }
            }
            vozila.Add(v);
            sacuvajVozilo();
            return true;

        }

        public bool novServis(Servisi s)
        {
           
            servisi.Add(s);
            sacuvajServis();
            return true;

        }

        
                public bool brisanjeKorisnika(Korisnik k)
                {

                    foreach (Korisnik l1 in korisnici)
                    {
                        if (l1.Id == k.Id)
                        {
                            korisnici.Remove(k);
                            sacuvajKorisnika();

                            return true;
                        }
                    }

                    return false;
                }


        
                public bool brisanjeVozila(Vozilo e)
                {

                    foreach (Vozilo e1 in vozila)
                    {
                        if (e1.RegBroj == e.RegBroj)
                        {
                            vozila.Remove(e);
                            sacuvajVozilo();
                            return true;
                        }
                    }

                    return false;
                }

        /*
                public bool brisanjeTipa(Tip t)
                {

                    foreach (Tip t1 in tipovi)
                    {
                        if (t1.Oznaka == t.Oznaka)
                        {
                            tipovi.Remove(t);
                            sacuvajTip();
                            return true;
                        }
                    }

                    return false;
                }
        */

        public ObservableCollection<Korisnik> Korisnici
        {
            get { return korisnici; }
            set { korisnici = value; }
        }


        public ObservableCollection<Vozilo> Vozila
        {

            get { return vozila; }
            set { vozila = value; }
        }

        public ObservableCollection<Servisi> Servisi
        {

            get { return servisi; }
            set { servisi = value; }
        }

    }
}
