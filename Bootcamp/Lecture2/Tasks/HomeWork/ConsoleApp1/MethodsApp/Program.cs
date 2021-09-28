using System;
using System.Text.RegularExpressions;

namespace MethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SwapNumbers();
            Point.TryParsePoint(out Point point);
        }

        /// <summary>
        /// Write a program to create a function to swap the values of two integer numbers.
        /// </summary>
        static void SwapNumbers()
        {
            int newNumber;

            Console.WriteLine("Please enter first number to swap");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number to swap");
            int secondNumer = Int32.Parse(Console.ReadLine());

            newNumber = firstNumber;
            firstNumber = secondNumer;
            secondNumer = newNumber;

            Console.WriteLine($"Now the 1st number is : {firstNumber} , and the 2nd number is : {secondNumer}");
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

            public static bool TryParsePoint(out Point point)
            {
                string pattern = "^[1-8](,[1-8])*$";

                Console.WriteLine("Please enter a comma coma-separated value e.g: 2,3 or 8,88");
                string cooridantes = Console.ReadLine().Replace(" ", "").ToString();

                bool IsCoordinatesValid = Regex.IsMatch(cooridantes, pattern);

                string[] array = cooridantes.Split(",");

                if (IsCoordinatesValid)
                {
                    if (int.TryParse(array[0], out int x) && int.TryParse(array[1], out int y))
                    {
                        point = new Point(x, y);
                        return true;
                    }
                }

                point = default;
                return false;

            }
        }
    }
}
