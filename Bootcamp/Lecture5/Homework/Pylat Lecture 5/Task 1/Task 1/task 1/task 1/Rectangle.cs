using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Rectangle : ForAll
    {
        int _X;

        public Rectangle(int x)
        {
            _X = x;
        }
        public void Draw()
        {
            Console.WriteLine($"This is {_X}");
        }
    }
}