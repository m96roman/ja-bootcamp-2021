using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest number : " + Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)));
            Console.WriteLine("Lowest number : " + Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber)));
        }
    }
}
