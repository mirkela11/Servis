using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servis.Model
{
    

   public class MaliServis
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
            set { if(filterUlja != value)
                {
                    filterUlja = value;
                    OnPropertyChanged("Filter ulja");
                } 
            }
        }
        public bool FilterKabine
        {
            get { return filterKabine; }
            set
            {
                if (filterKabine != value)
                {
                    filterKabine = value;
                    OnPropertyChanged("Filter kabine");

                }
            }
        }
        public bool FilterGoriva
        {
            get { return filterGoriva; }
            set
            {
                if (filterGoriva != value)
                {
                    filterGoriva = value;
                    OnPropertyChanged("Filter goriva");

                }
            }
        }
        public bool FilterVazduha
        {
            get { return filterVazduha; }
            set
            {
                if (filterVazduha != value)
                {
                    filterVazduha = value;
                    OnPropertyChanged("Filter vazduha");

                }
            }
        }
        public string Ulje
        {
            get { return ulje; }
            set
            {
                if (ulje != value)
                {
                    ulje = value;
                    OnPropertyChanged("Ulje");

                }
            }
        }
        public int Kolicina
        {
            get { return kolicina; }
            set
            {
                if (kolicina != value)
                {
                    kolicina = value;
                    OnPropertyChanged("Kolicina");

                }
            }
        }

        public MaliServis()
        {

        }

        public MaliServis(bool filterUlja, bool filterVazduha, bool filterKabine, bool filterGoriva, string ulje, int kolicina)
        {
            this.filterUlja = filterUlja;
            this.filterVazduha = filterVazduha;
            this.filterKabine = filterKabine;
            this.FilterGoriva = filterGoriva;
            this.ulje = ulje;
            this.kolicina = kolicina;
        }

        public void setAll(MaliServis ms)
        {
            filterUlja = ms.filterUlja;
            filterVazduha = ms.filterVazduha;
            filterKabine = ms.filterKabine;
            filterGoriva = ms.filterGoriva;
            ulje = ms.ulje;
            kolicina = ms.kolicina;
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
