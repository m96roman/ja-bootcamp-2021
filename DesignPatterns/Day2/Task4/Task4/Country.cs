using System;
using System.Collections.Generic;

namespace Task4
{
    class Country
    {
        private string _Name { get; set; }
        private List<City> _Cities { get; set; }
        private List<Region> _Regions { get; set; }

        public Country(string name, List<City> cities, List<Region> regions)
        {
            _Name = name;
            _Cities = cities;
            _Regions = regions;
        }

        public void GetInformation()
        {
            Console.WriteLine($@"Name: {this._Name}, cities: {this._Cities.Count}, Regions: {this._Regions.Count}");
        }

        public void ChangePopulation(string nameOfTheCity, int population)
        {
            for (int i = 0; i < _Cities.Count; i++)
            {
                if (_Cities[i].Name == nameOfTheCity)
                {
                    _Cities[i].Population = population;
                    Console.WriteLine(_Cities[i].Population);
                }
            }
        }

        public void ChangeRegionName(string oldName, string newName)
        {
            for (int i = 0; i < _Regions.Count; i++)
            {
                if (_Regions[i].Name == oldName)
                {
                    _Regions[i].Name = newName;
                }
            }
        }

        public Country CountryClone()
        {
            Country clone = (Country)this.MemberwiseClone();
            clone._Cities = _Cities;
            clone._Regions = _Regions;
            clone._Name = _Name;
            return clone;
        }
    }
}
