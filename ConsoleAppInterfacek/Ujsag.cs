using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfacek
{
    class Ujsag : IKolcsonozheto
    {
        string cim;
        int kiadasEv;
        int kiadasHonap;

        public Ujsag(string cim, int kiadasEv, int kiadasHonap)
        {
            this.cim = cim;
            this.kiadasEv = kiadasEv;
            this.kiadasHonap = kiadasHonap;
        }

        public int KolcsonzesiIdo()
        {
            return 0;
        }

        public string MegjelenitendoNev()
        {
            return String.Format("{0} - {1}.{2}", cim, kiadasEv, kiadasHonap);
        }
    }
}
