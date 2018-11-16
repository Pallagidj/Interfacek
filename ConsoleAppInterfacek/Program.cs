using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfacek
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Dvd d1 = new Dvd("Star Wars BIV", 180);
            Dvd d2 = new Dvd("Star Wars CV", 230);
            Dvd d3 = new Dvd("Star Wars AII", 210);
            Dvd d4 = new Dvd("Nem sztár vársz",230);
            
            var katalogus = new List<IKolcsonozheto>();
            katalogus.Add(d1);
            katalogus.Add(d2);
            katalogus.Add(d3);
            katalogus.Add(new Konyv("Harry Potter és a Bölcsek köve", "J.K. Rowling", "963-8386-77-0"));
            katalogus.Add(new Ujsag("Blikk",2016,3));
            
            //Console.WriteLine(katalogus[0].MegjelenitendoNev() + ", " + katalogus[0].KolcsonzesiIdo());

            var dvdk = new List<Dvd>();

            dvdk.Add(d1);
            dvdk.Add(d2);
            dvdk.Add(d3);
            dvdk.Add(d4);

            foreach (var item in dvdk)
            {
                Console.WriteLine(item.Cim + " " +item.TeljesHosszOra());
            }
            dvdk.Sort();
            Console.WriteLine();

            foreach (var item in dvdk)
            {
                Console.WriteLine(item.Cim + " " + item.TeljesHosszOra());
            }

            Console.ReadLine();
        }
    }
}
