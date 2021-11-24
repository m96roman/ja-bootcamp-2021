using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = new City("Lviv", 25);
            var region = new Region("Lvivskiy", 35);
            var country = new Country("Ukraine", city, region);

            var country2 = country.Copy() as Country;
            country.Print();
            Console.WriteLine();
            country2.Print();

            country2.ChangePopulation("Lviv", 10);
            country2.ChangeRegionName("Lvivskiy", "Nema");
            Console.WriteLine("*******************AFTER************************************************************");

            country.Print();
            Console.WriteLine();
            country2.Print();
            Console.ReadKey();

        }
    }
}
