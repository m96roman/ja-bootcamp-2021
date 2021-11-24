using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            City city = new City() { Name = "Lviv", Population = 123 };
            City city1 = new City() { Name = "Uzhorod", Population = 453 };
            cities.Add(city);
            cities.Add(city1);

            List<Region> regions = new List<Region>();
            Region region = new Region() { Name = "Lvivska", Square = 302 };
            Region region1 = new Region() { Name = "Zakarpatska", Square = 302 };
            regions.Add(region);
            regions.Add(region1);

            Country ukraine = new Country("Ukraine", cities, regions);

            ukraine.GetInformation();



            Country poland = ukraine.CountryClone();

            poland.GetInformation();
            ukraine.ChangePopulation("Lviv", 2354);
            poland.ChangePopulation("Lviv", 500);
        }
    }
}
