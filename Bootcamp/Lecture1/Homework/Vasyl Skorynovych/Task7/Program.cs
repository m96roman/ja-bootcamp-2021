using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number % 3 == 0 || number % 7 == 0);
        }
    }
}
