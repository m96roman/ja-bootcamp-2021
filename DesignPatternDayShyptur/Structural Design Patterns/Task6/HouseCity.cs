using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class HouseCity
    {
      private  Dictionary<string, Dictionary<int, IHouse>> city;
        public HouseCity()
        {
            city = new Dictionary<string, Dictionary<int, IHouse>>();
        }
        public void AddStreet(string nameStreet)
        {
            city.Add(nameStreet, new Dictionary<int, IHouse>());
        }
        public void AddHouseInStreet(string nameStreet,int numberHouse,IHouse house)
        {
            if (city.TryGetValue(nameStreet, out Dictionary<int, IHouse> street))
            {
                street.Add(numberHouse, house);
            }
        }
    }
}
