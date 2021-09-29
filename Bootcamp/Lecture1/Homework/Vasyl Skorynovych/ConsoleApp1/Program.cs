using System;

namespace ConsoleApp1
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

            int multiplicationResult = firstNumber * secondNumber * thirdNumber;

            Console.WriteLine("\n Result of multiplication: " + multiplicationResult);
            
        }
    }
}
