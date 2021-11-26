using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6_FlyWeight
{
    class Street
    {
        List<House> houses = new List<House>();

        public void AddHouse(House house)
        {
            houses.Add(house);
        }

        public void Print()
        {
            foreach (var house in houses)
            {
                Console.WriteLine($@"House type is: {house.GetHouseType()} and has {house.GetStages()} stages");
            }
        }
    }
}
