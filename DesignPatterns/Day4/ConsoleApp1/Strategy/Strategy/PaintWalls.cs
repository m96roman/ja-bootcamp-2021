using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class PaintWalls : IDecoration
    {
        public void DecorateWalls()
        {
            Console.WriteLine("Paint the walls");
        }
    }
}
