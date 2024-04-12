using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_5
{
    internal class Firma : Wpis
    {
        private String name;
        public Firma(String name, Address addr, NrTelefoniczny num)
        {
            this.name = name;
            this.address = addr;
            this.num = num;
        }
        public override string Opis()
        {
            return name + " LLC." + "For business inquiries: " + address.toString() + ". Contact " + num.ToString();
        }
    }
}
