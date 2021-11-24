using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class MonolithBuilding : Buildings
    {
        public MonolithBuilding(int floorCount)
        {
            floors = floorCount;
        }
    }
}
