using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
   internal class HouseFactory
   {
       public Dictionary<string,House> houses = new Dictionary<string, House>();

       public HouseFactory()
       {
           houses.Add("Panel 6",new PanelHouse(6));
           houses.Add("Panel 9", new PanelHouse(9));
           houses.Add("Brick 5", new BrickHouse());
           houses.Add("Monolothic 9",new MonolithicHouse(9));
           houses.Add("Monolothic 20", new MonolithicHouse(20));
        }

        public House GetHouse(string key)
       {
           if (houses.ContainsKey(key))
               return houses[key];
           else
               return null;
       }
    }
}
