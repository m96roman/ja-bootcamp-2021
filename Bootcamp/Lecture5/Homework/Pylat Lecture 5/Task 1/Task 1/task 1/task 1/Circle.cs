using System;
using System.Collections.Generic;
using System.Text;

namespace task_5
{
    class Circle : ForAll
    {
        int _X;

        public Circle(int x)
        {
            _X = x;
        }
        public void Draw()
        {
            Console.WriteLine($"This is {_X}");
        }
    }
}