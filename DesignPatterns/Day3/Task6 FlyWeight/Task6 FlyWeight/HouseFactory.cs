using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_FlyWeight
{
    class HouseFactory
    {
        Dictionary<int, House> houses = new Dictionary<int, House>();

        public HouseFactory()
        {
            houses.Add(6, new MonolithicHouse(6));
           // houses.Add(house.GetStages(), new BrickHouse(house.GetStages()));
          //  houses.Add(house.GetStages(), new PanelHouse(house.GetStages()));
        }

        public House GetHouse(int key)
        {
            if (!houses.ContainsKey(key))
            {
                return null;
            }
            return houses[key];
        }
    }
}
