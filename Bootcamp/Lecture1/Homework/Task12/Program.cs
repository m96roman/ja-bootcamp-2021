using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountNumbersDivisible = 0;

            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numbers between first and second that are divisible by 8 -> ");
            for(int i = firstNumber; i < secondNumber; i++)
            {
                if (i % 8 == 0)
                {
                    Console.Write(i.ToString() + " ");
                    amountNumbersDivisible++;
                }
            }

            Console.WriteLine("Amount numbers divisible by 8: " + amountNumbersDivisible);
        }
    }
}
