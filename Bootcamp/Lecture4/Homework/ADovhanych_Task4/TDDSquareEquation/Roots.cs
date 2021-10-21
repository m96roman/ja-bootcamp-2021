using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSquareEquation
{
    class Roots
    {
        public double Root1 { get; set; }
        public double Root2 { get; set; }

        public Roots (double x)
        {
            Root1 = x;
        }

        public Roots (double x1, double x2)
        {
            Root1 = x1;
            Root2 = x2;
        }
    }
}
