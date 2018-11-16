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

            Dvd d4 = d2;
            Console.WriteLine(d4.Cim);

            d2.Cim = "Star Wars II";

            Console.WriteLine(d4.Cim);

            foreach (var item in dvdk)
            {
                Console.WriteLine(item.Cim);
            }

            Console.ReadLine();
        }
    }
}
