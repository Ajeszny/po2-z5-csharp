using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_5
{
    internal class Address
    {
        private String street;
        private String city;
        private int number;

        public int getNumber()
        {
            return number;
        }

        public String getCity()
        {
            return city;
        }

        public String getStreet()
        {
            return street;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public void setNumber(int number)
        {
            this.number = number;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public String toString()
        {
            return this.city + ", " + this.street + ", " + this.number;
        }
        public Address(String city, String street, int number)
        {
            this.city = city;
            this.number = number;
            this.street = street;
        }
    }
}
