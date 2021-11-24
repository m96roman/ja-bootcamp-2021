using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> ukraineCities = new List<City>
            {
                 new City() { cityName = "Uzhgorod", cityPopulation = 100000 },
                  new City() { cityName = "Lviv", cityPopulation = 900000 },
            };

            List<Region> ukarineRegions = new List<Region>
            {
                new Region(){regionName = "Transcarpatian", regionArea = 12777 },
                 new Region(){regionName = "Lvivsjka", regionArea = 21831 },

            };

            AbstractCountry ukraine = new Country("Ukraine", ukarineRegions, ukraineCities);
            AbstractCountry poland = ukraine.Clone();
          
            Console.WriteLine("----------Ukraine created--------");
            ukraine.ShowInfo();
        
            Console.WriteLine("----------Poland copy--------");
            poland.ShowInfo();
           
            poland.ChangePopulationCount("Uzhgorod", 200000);
            poland.ChangeRegion("Lvivsjka", "Galicjka");
          
            Console.WriteLine("----------Poland after changes--------");
            poland.ShowInfo();
          
            Console.WriteLine("----------Ukraine after changes--------");
            ukraine.ShowInfo();
        }
    }
}
