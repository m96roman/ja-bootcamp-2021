using System;

namespace Task2_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validPoint1, validPoint2 = false;

            Console.WriteLine("Input your point: ");
            string pointInputed = Console.ReadLine();
            validPoint1 = TryParsePoint(pointInputed, out Point? point1);

            Console.WriteLine("Input your point: ");
            pointInputed = Console.ReadLine();
            validPoint2 = TryParsePoint(pointInputed, out Point ? point2);
            
            if(validPoint1)
            {
                Console.WriteLine($"- Result of parsing: true,{point1.Value.ToString()}");
            }
            else
            {
                Console.WriteLine($"- Result of parsing: true, Point = undefined");
            }
            if (validPoint2)
            {
                Console.WriteLine($"- Result of parsing: true,{point2.Value.ToString()}");
            }
            else
            {
                Console.WriteLine($"- Result of parsing: true, Point = undefined");
            }
        }


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

        static bool TryParsePoint(string pointInputed, out Point? point)
        {
            string[] values = pointInputed.Split(',');

            int x, y;
            if (int.TryParse(values[0], out x) && int.TryParse(values[1], out y))
            {
                point = new Point(x, y);
                return true;
            }
            else
            {
                point = null;
                return false;
            }
        }
    }
}
