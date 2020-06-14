using Servis.Dijalozi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Servis.Model
{
	public class Vozilo
	{
		private String markaVozila = "";
		private String modelVozila = "";
		private String regBroj = "";
		private String brojSasije = "";
		private Korisnik korisnik = new Korisnik();

		public Korisnik Korisnik

        {
			get { return korisnik; }
			set {
				if (value != korisnik) {
					korisnik = value;
					OnPropertyChanged("Korisnik");
				}
			}
        }
		
		public string MarkaVozila
		{
			get
			{
				return markaVozila;
			}
			set
			{
				if (value != markaVozila)
					markaVozila = value;
					OnPropertyChanged("Marka vozila");
			}
		}

		public string ModelVozila
		{
			get
			{
				return modelVozila;
			}
			set
			{
				if (value != modelVozila)
					modelVozila = value;
				OnPropertyChanged("Model vozila");
			}
		}

		public string RegBroj
		{
			get
			{
				return regBroj;
			}
			set
			{
				if (value != regBroj)
					regBroj = value;
				OnPropertyChanged("Registarski broj");
			}
		}

		public string BrojSasije
		{
			get
			{
				return brojSasije;
			}
			set
			{
				if (value != brojSasije)
					brojSasije = value;
				OnPropertyChanged("Broj sasije");
			}
		}

		public Vozilo() {
			korisnik = new Korisnik();
		}

		public Vozilo(String markaVozila, String modelVozila, String regBroj, String brojSasije, Korisnik k)
        {
			
			this.markaVozila = markaVozila;
			this.modelVozila = modelVozila;
			this.regBroj = regBroj;
			this.brojSasije = brojSasije;
			this.korisnik = k;
        }

		public void setAll(Vozilo v)
		{
			
			markaVozila = v.markaVozila;
			modelVozila = v.modelVozila;
			regBroj = v.regBroj;
			brojSasije = v.brojSasije;
			korisnik = v.korisnik;

		}


		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void OnPropertyChanged(string v)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(v));
			}
		}
	} 
}
