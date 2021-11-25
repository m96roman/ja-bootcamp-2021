using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class BuildingCompany
    {
        Dictionary<string, House> houseTypes = new Dictionary<string, House>();

        public BuildingCompany()
        {
            houseTypes.Add("Brick5", new Brick5Stages());
            houseTypes.Add("Panel6", new Panel6Stages());
            houseTypes.Add("Panel9", new Panel9Stages());
            houseTypes.Add("Monolit9", new Monolit9Stages());
            houseTypes.Add("Monolit20", new Monolit20Stages());
        }

        public House GetHouseType(string type)
        {

            if (houseTypes.ContainsKey(type))
            {
                return houseTypes[type];
            }
            else
            {
                return null;
            }

        }
    }
}
