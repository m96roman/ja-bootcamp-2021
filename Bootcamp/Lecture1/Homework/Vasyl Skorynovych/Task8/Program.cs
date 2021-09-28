using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter string");
            string input = Console.ReadLine();

            if (input.StartsWith("C#"))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
