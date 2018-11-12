using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfacek
{
    class Dvd
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

        public double TeljesHosszOra()
        {
            return this.hossz / 60.0;
        }
    }
}
