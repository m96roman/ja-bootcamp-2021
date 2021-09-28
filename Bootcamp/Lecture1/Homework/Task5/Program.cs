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

            //finding largest number
            if (firstNumber > secondNumber)
            {
                //4
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("Largest number : " + firstNumber);
                }
                else
                {
                    Console.WriteLine("Largest number : " + thirdNumber);
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("Largest number : " + secondNumber);
                }
                else
                {
                    Console.WriteLine("Largest number : " + thirdNumber);
                }
            }

            //finding lowest number
            if (firstNumber < secondNumber)
            {
                //4
                if (firstNumber < thirdNumber)
                {
                    Console.WriteLine("Lowest number : " + firstNumber);
                }
                else
                {
                    Console.WriteLine("Lowest number : " + thirdNumber);
                }
            }
            else
            {
                if (secondNumber < thirdNumber)
                {
                    Console.WriteLine("v number : " + secondNumber);
                }
                else
                {
                    Console.WriteLine("Lowest number : " + thirdNumber);
                }
            }
        }
    }
}
