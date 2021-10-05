using System;

namespace Task2_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
 
            bool validPoint1 = TryParsePoint(ReadPointFromConsole(), out Point? point1);
            bool validPoint2 = TryParsePoint(ReadPointFromConsole(), out Point ? point2);

            ValidParsing(validPoint1, point1);
            ValidParsing(validPoint2, point2);
        }

        static void ValidParsing(bool validPoint, Point? point)
        {
            if (validPoint)
            {
                Console.WriteLine($"- Result of parsing: true,{point.Value}");
            }
            else
            {
                Console.WriteLine($"- Result of parsing: true, Point = undefined");
            }
        }

        static string ReadPointFromConsole()
        {
            Console.WriteLine("Input your point: ");
            return Console.ReadLine();
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
