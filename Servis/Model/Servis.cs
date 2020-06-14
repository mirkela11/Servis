using Servis.Dijalozi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis.Model
{

   public class Servisi
    {
        private Korisnik korisnik = new Korisnik();
        private Vozilo vozilo = new Vozilo();
        private int predjenaKilometraza;
        private MaliServis ms = new MaliServis();

        public Korisnik Korisnik

        {
            get { return korisnik; }
            set
            {
                if (value != korisnik)
                {
                    korisnik = value;
                    OnPropertyChanged("Korisnik");
                }
            }
        }

        public Vozilo Vozilo

        {
            get { return vozilo; }
            set
            {
                if (value != vozilo)
                {
                    vozilo = value;
                    OnPropertyChanged("Vozilo");
                }
            }
        }

        public MaliServis MaliServis

        {
            get { return ms; }
            set
            {
                if (value != ms)
                {
                    ms = value;
                    OnPropertyChanged("Mali servis");
                }
            }
        }

        public int PredjenaKilometraza
        {
            get { return predjenaKilometraza; }
            set
            {
                if(value != predjenaKilometraza)
                {
                    predjenaKilometraza = value;
                    OnPropertyChanged("Predjena kilometraza");

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public Servisi() { }

        public Servisi(Korisnik korisnik, Vozilo vozilo, MaliServis ms, int predjenaKilometraza)
        {
            this.korisnik = korisnik;
            this.vozilo = vozilo;
            this.ms = ms;
            this.predjenaKilometraza = predjenaKilometraza;
        }

        public void setAll(Servisi s) 
        {
            korisnik = s.korisnik;
            vozilo = s.vozilo;
            ms = s.ms;
            predjenaKilometraza = s.predjenaKilometraza;
        }
    }
}
