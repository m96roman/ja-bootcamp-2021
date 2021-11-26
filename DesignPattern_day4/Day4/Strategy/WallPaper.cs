using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class WallPaper : IStrategy
    {
        public void Decor()
        {
            Console.WriteLine("I glue wallpaper");
        }
    }
}
