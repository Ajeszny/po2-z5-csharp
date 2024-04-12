using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_5
{
    internal class Osoba : Wpis
    {
        public String name;
        public String surname;
        public Osoba(String name, String surname, Address addr, NrTelefoniczny num)
        {
            this.name = name;
            this.surname = surname;
            this.address = addr;
            this.num = num;
        }
        public override String Opis()
        {
            return this.name + " " + this.surname + "." + " Lives at " + address.toString() + "." + "Number: " + num.ToString() + ".";
        }
    }
}
