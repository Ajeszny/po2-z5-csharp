using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_5
{
    internal abstract class Wpis
    {
        public NrTelefoniczny num;
        public Address address;
        public abstract string Opis();
    }
}
