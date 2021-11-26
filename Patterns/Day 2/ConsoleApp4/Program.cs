using ConsoleApp4.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> BigCities = new List<City>()
            {
                new City(){ Name = "Lviv", AmountCitizens = 750_000 },
                new City(){ Name = "Kyiv",AmountCitizens = 1_500_000 },
                new City(){ Name = "Uzhhorod", AmountCitizens = 100_000 }
            };

            List<Region> Regions = new List<Region>()
            {
                new Region(){ Name = "Lviv region", Square = 23.65 },
                new Region(){ Name = "Kyiv region", Square = 56345.65 },
                new Region(){ Name = "Uzhhorod region", Square = 534.765 }
            };

            Country country1 = new Country("Ukraine", BigCities, Regions);
            Console.WriteLine();
            Console.WriteLine("--- country 1 ---");
            country1.GetInformation();

            Country country2 = (Country)country1.Clone();

            country2.RenameRegion("Lviv region", "New Lviv region");
            country2.ChangeAmountCitizens("Lviv", 1_000_000);
            Console.WriteLine();
            Console.WriteLine("--- country 2 cloned ---");
            country2.GetInformation();

            Console.WriteLine();
            Console.WriteLine("--- country 1 after clonning ---");
            country1.GetInformation();
        }
    }
}
