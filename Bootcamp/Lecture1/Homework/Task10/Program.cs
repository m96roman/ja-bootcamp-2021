using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumEnteredNumbers = 0;
            for(int i = 0; i < 10; i++)
            {
                double enteredNumber = Convert.ToInt32(Console.ReadLine());
                sumEnteredNumbers += enteredNumber;
            }
            Console.WriteLine("Sum entered numbers = " + sumEnteredNumbers);
            Console.WriteLine("Average entered numbers = " + sumEnteredNumbers / 2.0);
        }
    }
}
