using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Country : AbstractCountry
    {
        private string _countryName;
        private List<Region> _regions;
        private List<City> _bigCities;

        public Country(string countryName, List<Region> regions, List<City> cities) : base(countryName, regions, cities)
        {
            _countryName = countryName;
            _regions = regions;
            _bigCities = cities;

        }
        public override List<City> ChangePopulationCount(string name, int countount)
        {
            _bigCities.Where(i => i.cityName == name).Select(c => { c.cityPopulation = countount; return c; }).ToList();
            return _bigCities;
        }
        public override List<Region> ChangeRegion(string currentRegionName, string newRegionName)
        {
            _regions.Where(i => i.regionName == currentRegionName).Select(c => { c.regionName = newRegionName; return c; }).ToList();
            return new List<Region>();
        }
        public override void ShowInfo()
        {
            foreach (var item in _bigCities)
            {
                Console.WriteLine($"{item.cityName}, {item.cityPopulation}");
            }

            foreach (var item in _regions)
            {
                Console.WriteLine($"{item.regionName}, {item.regionArea}");
            }

        }
       public override AbstractCountry Clone()
        {
            List<Region> copiedRegion = new List<Region>();
            List<City> copiedCities = new List<City>();

            foreach (var item in _regions)
            {
                copiedRegion.Add(new Region() { regionName = item.regionName, regionArea = item.regionArea });
            }

            foreach (var item in _bigCities)
            {
                copiedCities.Add(new City() { cityName = item.cityName,  cityPopulation = item.cityPopulation });
            }
            string copiedName = _countryName;
            return new Country(copiedName, copiedRegion, copiedCities);
        }
        
    }
}
