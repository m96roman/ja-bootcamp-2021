using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
   internal class PanelHouse:House
    {

        public PanelHouse(int stages)
        {
            this.Floor = stages;
        }
        public override void BuildHouse(Street street)
        {
            Console.WriteLine($"Build PanelHouse with {Floor} on the street : {street.Name}.");
            street.AddHouseTostreet(this);

        }
    }
}
