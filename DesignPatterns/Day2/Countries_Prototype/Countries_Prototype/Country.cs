using System;
using System.Collections.Generic;

namespace Countries_Prototype
{
    class Country : ICloneable
    {
        public Country(string name, List<Region> regions, List<City> cities)
        {
            Name = name;
            Regions = regions;
            Cities = cities;
        }

        private string Name { get; set; }

        public List<Region> Regions { get; private set; }

        public List<City> Cities { get; private set; }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(string.Join(", ", Cities));
            Console.WriteLine(string.Join(", ", Regions));
        }

        public void ChangeCityPopulation(string cityName, int cityPopulation)
        {
            var city = Cities.Find(c => c.Name == cityName);
            city.Population = cityPopulation;
        }

        public void RenameRegion(string oldregionName, string newRegionName)
        {
            var region = Regions.Find(r => r.Name == oldregionName);
            region.Name = newRegionName;
        }

        public object Clone()
        {
            Country clone = (Country)this.MemberwiseClone();

            clone.Regions = new List<Region>(this.Regions.Count);
            clone.Cities = new List<City>(this.Cities.Count);

            this.Regions.ForEach(region =>
            {
                clone.Regions.Add((Region)region.Clone());
            });

            this.Cities.ForEach(city =>
            {
                clone.Cities.Add((City)city.Clone());
            });

            return clone;
        }
    }
}
