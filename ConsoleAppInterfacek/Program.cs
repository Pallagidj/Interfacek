using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfacek
{
    class Program
    {
        int szam;
        string szoveg;
        int[] tomb;


        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine(p1.szam);
            Console.WriteLine(p1.szoveg);
            Console.WriteLine(p1.tomb);


            Dvd d1 = new Dvd("Star Wars IV", 180);
            Dvd d2 = new Dvd("Star Wars V", 230);
            Dvd d3 = new Dvd("Star Wars VI", 210);

            var katalogus = new List<object>();
            katalogus.Add(d1);
            katalogus.Add(d2);
            katalogus.Add(d3);
            katalogus.Add(new Konyv("Harry Potter és a Bölcsek köve", "J.K. Rowling", "963-8386-77-0"));
            katalogus.Add(new Ujsag("Blikk",2016,3));

            var dvdk = new List<Dvd>();

            dvdk.Add(d1);
            dvdk.Add(d2);
            dvdk.Add(d3);

            foreach (var item in dvdk)
            {
                Console.WriteLine(item.Cim);
            }

            d2.Cim = "Star Wars II";

            foreach (var item in dvdk)
            {
                Console.WriteLine(item.Cim);
            }

            Console.ReadLine();
        }
    }
}
