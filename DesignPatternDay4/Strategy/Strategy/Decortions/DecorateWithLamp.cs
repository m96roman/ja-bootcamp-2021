using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DecorateWithLamp : IDecorate
    {
        public void DecorateWall()
        {
            Console.WriteLine("I decorate wall with Lamps.");
        }
    }
}
