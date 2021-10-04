using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task5
{
    class Point : Drawable
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"Point : {(X, Y)}");
        }
    }
}
