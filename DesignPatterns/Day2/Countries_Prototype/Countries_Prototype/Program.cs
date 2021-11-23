using System.Collections.Generic;

namespace Countries_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("123",
                new List<Region> { new Region("Georgia", 1200) },
                new List<City> { new City("Fukusima", 1000000) });

            country.PrintInfo();

            System.Console.WriteLine(new string('-', 20));

            var countryClone = (Country)country.Clone();

            countryClone.ChangeCityPopulation("Fukusima", 0);
            countryClone.RenameRegion("Georgia", "New Georgia");

            countryClone.PrintInfo();

            System.Console.WriteLine(new string('-', 20));

            country.PrintInfo();
        }
    }
}
