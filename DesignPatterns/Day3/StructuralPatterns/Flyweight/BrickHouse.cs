using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class BrickHouse:House
    {
        public BrickHouse()
        {
            this.Floor = 5;
        }
        public override void BuildHouse(Street street)
        {
            Console.WriteLine($"Build BrickHouse with {Floor} on the street : {street.Name}.");
            street.AddHouseTostreet(this);
        }
    }
}
