using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis.Model
{
    class BazaPodataka
    {
        private ObservableCollection<Korisnik> korisnik = new ObservableCollection<Korisnik>();
        private ObservableCollection<Vozilo> vozilo = new ObservableCollection<Vozilo>();

        private string pathKorisnik = null;
        private string pathVozilo = null;

        //string korisnik = 

        public BazaPodataka()
        {

            pathKorisnik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "korisnik.txt");
            pathVozilo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vozilo.txt");

            ucitajKorisnike();
            ucitajVozila();
            sacuvajKorisnika();

        }




        public void ucitajKorisnike()
        {

            if (File.Exists(pathKorisnik))
            {

                using (StreamReader reader = File.OpenText(pathKorisnik))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    korisnik = (ObservableCollection<Korisnik>)serializer.Deserialize(reader, typeof(ObservableCollection<Korisnik>));
                }
            }
            else
            {
                korisnik = new ObservableCollection<Korisnik>();
            }


        }


        public void ucitajVozila()
        {


            if (File.Exists(pathVozilo))
            {

                using (StreamReader reader = File.OpenText(pathVozilo))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    vozilo = (ObservableCollection<Vozilo>)serializer.Deserialize(reader, typeof(ObservableCollection<Vozilo>));
                }

            }
            else
            {
                vozilo = new ObservableCollection<Vozilo>();
            }



        }


        public void save()
        {

            using (StreamWriter writer = File.CreateText(pathKorisnik))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, korisnik);
                writer.Close();
            }

            using (StreamWriter writer = File.CreateText(pathVozilo))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, vozilo);
                writer.Close();
            }

        }


        public void sacuvajKorisnika()
        {
            using (StreamWriter writer = File.CreateText(pathKorisnik))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, korisnik);
                writer.Close();
            }


        }



        public void sacuvajVozilo()
        {
            using (StreamWriter writer = File.CreateText(pathVozilo))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, vozilo);
                writer.Close();
            }


        }


        public bool novKorisnik(Korisnik k)
        {
            foreach (Korisnik k1 in korisnik)
            {
                if (k1.Id == k.Id)
                {

                    return false;
                }
            }
            korisnik.Add(k);
            sacuvajKorisnika();

            return true;
        }


        public bool novoVozilo(Vozilo v)
        {
            foreach (Vozilo v1 in vozilo)
            {
                if (v1.RegBroj.Equals(v.RegBroj) )
                {

                    return false;
                }
            }
            vozilo.Add(v);
            sacuvajVozilo();
            return true;

        }
/*
        public bool brisanjeSpomenika(Spomenik s)
        {

            foreach (Spomenik l1 in spomenici)
            {
                if (l1.Oznaka == s.Oznaka)
                {
                    spomenici.Remove(s);
                    sacuvajSpomenik();

                    return true;
                }
            }

            return false;
        }



        public bool brisanjeEtikete(Etiketa e)
        {

            foreach (Etiketa e1 in etikete)
            {
                if (e1.Oznaka == e.Oznaka)
                {
                    etikete.Remove(e);
                    sacuvajEtiketu();
                    return true;
                }
            }

            return false;
        }


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
            get { return korisnik; }
            set { korisnik = value; }
        }


        public ObservableCollection<Vozilo> Vozila
        {

            get { return vozilo; }
            set { vozilo = value; }
        }

    }
}
