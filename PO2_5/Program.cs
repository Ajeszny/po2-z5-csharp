using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<NrTelefoniczny, Wpis> ht = new SortedDictionary<NrTelefoniczny, Wpis>();

            //Ludzie
            Osoba osoba1 = new Osoba("Zlotheus", "Zlei", new Address("Orel", "Seregowa", 3), new NrTelefoniczny(22, 123456789));
            Osoba osoba2 = new Osoba("Sergei", "Zlaxow", new Address("Stepnogorsk", "Politechniki", 7), new NrTelefoniczny(22, 987654321));
            Osoba osoba3 = new Osoba("Ajeszny", "Zlei", new Address("Łódź", "Seregowa", 23), new NrTelefoniczny(22, 1337));
            //Firmy
            Firma firma1 = new Firma("Adeptus Vadimus", new Address("Zleeburg", "Seregowa", 15), new NrTelefoniczny(510, 0xB00B));
            Firma firma2 = new Firma("SKN main()", new Address("Пучины ада", "Politechniki", 3), new NrTelefoniczny(510, 342534636));

            ht.Add(osoba1.num, osoba1);
            ht.Add(osoba2.num, osoba2);
            ht.Add(osoba3.num, osoba3);

            ht.Add(firma1.num, firma1);
            ht.Add(firma2.num, firma2);



            foreach (Wpis h in ht.Values)
            {
                Console.WriteLine(h.Opis());
            }

            SortedDictionary<NrTelefoniczny, Wpis>.Enumerator i =  ht.GetEnumerator();

            HashSet<string> keys = new HashSet<string>();
            SortedDictionary<NrTelefoniczny, Wpis> new_dict = new SortedDictionary<NrTelefoniczny, Wpis>();

            while (i.MoveNext())
            {
                if (keys.Contains(i.Current.Value.address.getStreet()))
                {
                    continue;
                }
                new_dict.Add(i.Current.Key, i.Current.Value);
                keys.Add(i.Current.Value.address.getStreet());
            }
            Console.WriteLine("Zawartość książki telefonicznej po eliminacji duplikatów:");
            foreach (Wpis h in new_dict.Values)
            {
                Console.WriteLine(h.Opis());
            }
        }
    }
}
