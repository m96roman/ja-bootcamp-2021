using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sumIntegers = firstNumber + secondNumber;

            if (firstNumber == secondNumber)
                Console.WriteLine("Numbers are equal, result = " + sumIntegers * 3);
            else
            {
                Console.WriteLine("Numbers are not equal, result = " + sumIntegers / 8.0);
            }
        }
    }
}
