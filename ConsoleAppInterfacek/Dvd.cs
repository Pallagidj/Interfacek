using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfacek
{
    class Dvd : IKolcsonozheto , IComparable<Dvd>
    {
        private string cim;
        private int hossz; //perc

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public string Cim
        {
            get
            {
                return cim;
            }

            set
            {
                cim = value;
            }
        }

        public int Hossz
        {
            get
            {
                return hossz;
            }

            set
            {
                hossz = value;
            }
        }

        public int CompareTo(Dvd other)
        {
           // return this.cim.CompareTo(other.cim); //csak egy rendezési feltételnél
            //return this.hossz - other.hossz; //csak számoknál
            
            if (this.hossz > other.hossz)
            {
                
                return 1;
            }
            else if(this.hossz < other.hossz)
            {
                return -1;
            }
            else
            {
                if (this.cim.CompareTo(other.cim) > 0)
                {
                    return 1;
                }
                else if (this.cim.CompareTo(other.cim) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            
        }

        public int KolcsonzesiIdo()
        {
            return 7;
        }

        public string MegjelenitendoNev()
        {
            return cim;
        }

        public double TeljesHosszOra()
        {
            return this.hossz / 60.0;
        }
    }
}
