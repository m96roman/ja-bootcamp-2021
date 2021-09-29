using System;
using System.Text.RegularExpressions;

namespace MethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter first number to swap");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter second number to swap");
            //int secondNumber = int.Parse(Console.ReadLine());
            //SwapNumbers(ref firstNumber, ref secondNumber);

            Console.WriteLine("Please enter a comma coma-separated value e.g: 2,3 or 8,88");
            string input = Console.ReadLine().Replace(" ", "").ToString();
            Point.TryParsePoint(input, out Point point);
        }

        /// <summary>
        /// Write a program to create a function to swap the values of two integer numbers.
        /// </summary>
        static void SwapNumbers(ref int firstNumber, ref int secondNumber)
        {
            int newNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = newNumber;

            Console.WriteLine($"Now the 1st number is : {firstNumber} , and the 2nd number is : {secondNumber}");
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

            public static bool TryParsePoint(string input, out Point point)
            {
                string pattern = "^[1-8](,[1-8])*$";

                bool IsCoordinatesValid = Regex.IsMatch(input, pattern);

                string[] array = input.Split(",");

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
