using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Draw : IStrategy
    {
        public void Decor()
        {
            Console.WriteLine("I Draw");
        }
    }
}
