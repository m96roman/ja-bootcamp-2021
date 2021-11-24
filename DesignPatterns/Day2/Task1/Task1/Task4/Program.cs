using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> listCity = new List<City>() { new City { NameCity = "Uzh", Population = 1000 }, new City { NameCity = "Lviv", Population = 500 } };
            List<Region> listRegions = new List<Region>() { new Region { NameRegion = "Transkarpatiya", SquareRegion = 1.2 }, new Region { NameRegion = "Lvivska", SquareRegion = 5 } };
            Country ukraine = new Country("Ukraine", listCity, listRegions);
            Country spain = ukraine.CloneCountry();

            ukraine.GetInformation();
            spain.GetInformation();

            spain.ChangeNameRegion("Lvivska", "Kievska");
            spain.ChangePopulationInCity("Uzh", 9000);
            spain.GetInformation();
        }
    }
}
