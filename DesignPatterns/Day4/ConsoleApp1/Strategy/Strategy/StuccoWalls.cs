using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class StuccoWalls : IDecoration
    {
        public void DecorateWalls()
        {
            Console.WriteLine("Stucco decaoration for walls");
        }
    }
}
