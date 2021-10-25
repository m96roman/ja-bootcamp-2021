using System;

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

        public override void PrintArea()
        {
            Console.WriteLine($"Point : {(X, Y)}");
        }
    }
}
