using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis.Model
{
	public class Korisnik
	{
        private int id;
		private string ime = "";
		private string prezime = "";
        private string brojTelefona = "";
	private DateTime datum = DateTime.Today;
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
                

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (value != ime)
                {
                    ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (value != prezime)
                {
                    prezime = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }

        public string BrojTelefona
        {
            get
            {
                return brojTelefona;
            }

            set
            {
                if (value != brojTelefona)
                {
                    brojTelefona = value;
                    OnPropertyChanged("Broj telefona");
                }
            }
        }

        public Korisnik() { }

        public Korisnik(int id, string ime, string prezime, string brojTelefona, DateTime datum)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.brojTelefona = brojTelefona;
            this.datum = datum;
        }

        public void setAll(Korisnik k)
        {
            id = k.id;
            ime = k.ime;
            prezime = k.prezime;
            brojTelefona = k.brojTelefona;
            datum = k.datum;
        }
            


        public virtual void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
    }






   
}
