using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
   internal class Street
    {
        public  string Name { get; set; }

        public List<House> House=new List<House>();

        public Street(string name)
        {
            Name = name;
        }

        public void AddHouseTostreet(House house)
        {
            House.Add(house);
        }

        public void Print()
        {
            Console.WriteLine("Street {0}:" ,Name);
            foreach (var house in  House)
            {
                Console.WriteLine($"House: {house.GetType().Name} with {house.Floor} floor");
            }
        }
    }
}
