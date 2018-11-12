using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfacek
{
    class Ujsag
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
    }
}
