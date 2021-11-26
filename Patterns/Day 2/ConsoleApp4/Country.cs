using ConsoleApp4.Interfaces;
using ConsoleApp4.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Country : ICountry
    {
        private string Name { get; set; }
        private List<City> BigCities;
        private List<Region> Regions;

        public Country(string name, List<City> bigCities, List<Region> regions)
        {
            Name = name;
            BigCities = bigCities;
            Regions = regions;
        }

        public void ChangeAmountCitizens(string nameCity, int amountCitizens)
        {
            foreach (var city in BigCities)
            {
                if (city.Name == nameCity)
                {
                    city.AmountCitizens = amountCitizens;
                }
            }
        }

        public ICountry Clone()
        {
            Country countryClone = this.MemberwiseClone() as Country;

            countryClone.BigCities = new List<City>();
            foreach (var city in BigCities)
            {
                countryClone.BigCities.Add(city.Clone() as City);
            }

            countryClone.Regions = new List<Region>();
            foreach (var region in Regions)
            {
                countryClone.Regions.Add(region.Clone() as Region);
            }

            return countryClone;
        }

        public void GetInformation()
        {
            Console.WriteLine($"Information about country {Name}");
            Console.WriteLine("Big Cities:");
            foreach (var city in BigCities)
            {
                Console.WriteLine($" Name: {city.Name} - Amount Citizens: {city.AmountCitizens}");
            }
            Console.WriteLine("Regions:");
            foreach (var region in Regions)
            {
                Console.WriteLine($" Name: {region.Name} - Square: {region.Square}");
            }
        }

        public void RenameRegion(string olnName, string newName)
        {
            foreach (var region in Regions)
            {
                if (region.Name == olnName)
                {
                    region.Name = newName;
                }
            }
        }
    }
}
