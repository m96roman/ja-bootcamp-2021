using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class AbstractCountry
    {
        private string _countryName;
        private List<Region> _regions;
        private List<City> _bigCities;

        public AbstractCountry(string countryName, List<Region> regions, List<City> cities)
        {
            this._countryName = countryName;
            this._regions = regions;
            this._bigCities = cities;
        }
        public abstract List<City> ChangePopulationCount(string name, int countount);
        public abstract List<Region> ChangeRegion(string currentRegionName, string newRegionName);
        public abstract void ShowInfo();
        public abstract AbstractCountry Clone();
    }
}
