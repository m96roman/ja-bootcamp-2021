using System;

namespace Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();

        }

        public static void Task2()
        {
            Point newPoint;
            newPoint._X = Console.ReadLine();
            newPoint.TryParsePoint();

        }

        public static void Task1()
        {
            int firstNumber;
            int secondNumber;
            try
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error input");
                return;
            }

            SwapNumbers(ref firstNumber, ref secondNumber);
        }

        public struct Point
        {

            public string _X;

            public Point(string point1)
            {
                _X = point1;
            }

            public void TryParsePoint()
            {

                if (double.TryParse(_X, out double result))
                {
                    Console.WriteLine($"Result of parsing: true, Point = ({_X})");
                }
                else
                {
                    Console.WriteLine($"Result of parsing: false, Point = undefined");
                }

            }
        }

        static void SwapNumbers(ref int firstNumber, ref int secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine($"Now the 1st number is : {firstNumber} , and the 2nd number is : {secondNumber}");
        }
    }
}
