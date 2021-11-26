using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class GlueWallpers : IDecoration
    {
        public void DecorateWalls()
        {
            Console.WriteLine("Glue the wallpers on walls");
        }
    }
}
