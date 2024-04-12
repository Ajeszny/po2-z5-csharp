using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_5
{
    internal class NrTelefoniczny : IComparable<NrTelefoniczny>
    {

        short nrkierunkowy;
        int nrTelefonu;

        public NrTelefoniczny(int nk, int nt)
        {
            nrkierunkowy = (short)nk;
            nrTelefonu = nt;
        }

        public int CompareTo(NrTelefoniczny other) {
            if (this.nrkierunkowy != other.nrkierunkowy)
            {
                return 1 - 2 * ((this.nrkierunkowy > other.nrkierunkowy) ? 0 : 1);
            }
            return this.nrTelefonu - other.nrTelefonu;
        }
        public override string ToString()
        {
            return "+48 " + nrkierunkowy.ToString() + " " + nrTelefonu.ToString();
        }
    }
}
