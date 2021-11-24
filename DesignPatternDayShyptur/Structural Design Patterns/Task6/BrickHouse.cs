using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class BrickHouse : IHouse
    {
        public BrickHouse(int stagesInHouse)
        {
            Stages = stagesInHouse;
        }
    }
}
