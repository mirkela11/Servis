using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis.Model
{
	public class Vozilo
	{
		private String markaVozila = "";
		private String modelVozila = "";
		private String regBroj = "";
		private String brojSasije = "";


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

		public Vozilo() { }

		public void setAll(Vozilo v)
		{
			markaVozila = v.markaVozila;
			modelVozila = v.modelVozila;
			regBroj = v.regBroj;
			brojSasije = v.brojSasije;
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
