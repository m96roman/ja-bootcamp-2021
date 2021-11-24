using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Country
    {    
        private string Name { get; set; }
        private List<City> _CityNames { get; set; }
        private List<Region> _RegionNames { get; set; }

        public Country(string name, List<City> cityNames, List<Region> regionNames)
        {
            Name = name;
            _CityNames = cityNames;
            _RegionNames = regionNames;
        }
        public void ChangeNameRegion(string oldName,string newName)
        {
            for (int i = 0; i < _RegionNames.Count; i++)
            {
                if (_RegionNames[i].NameRegion==oldName)
                {
                    _RegionNames[i].NameRegion = newName;
                }
            }            
        }
        public void ChangePopulationInCity(string cityName, int population)
        {
            for (int i = 0; i < _CityNames.Count; i++)
            {
                if (_CityNames[i].NameCity == cityName)
                {
                    _CityNames[i].Population = population;
                }
            }
        }
        public void GetInformation()
        {
            Console.WriteLine(this.Name + " population = " +this._CityNames.Sum(x => x.Population)+" square="+this._RegionNames.Sum(s=>s.SquareRegion));
        }
        public Country CloneCountry()
        {
            Country clone = (Country)this.MemberwiseClone();
            clone._CityNames = _CityNames;
            clone._RegionNames = _RegionNames;
            clone.Name = Name;
            return clone;
        }
    }
}
