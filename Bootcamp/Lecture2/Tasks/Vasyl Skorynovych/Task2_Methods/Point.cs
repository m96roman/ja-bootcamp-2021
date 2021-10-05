using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Methods
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $" Point = {X}, {Y}";
        }
    }
}
