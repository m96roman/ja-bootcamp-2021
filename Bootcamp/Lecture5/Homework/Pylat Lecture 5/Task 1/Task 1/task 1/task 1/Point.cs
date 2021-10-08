using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Point : ForAll
    {
        int _X;

        public Point(int x)
        {
            _X = x;
        }

        public void Draw()
        {
            Console.WriteLine($"This is {_X}");
        }
    }
}