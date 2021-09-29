using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string str = Console.ReadLine();
            if (str.Length > 5)
                Console.WriteLine(str.Substring(0, 5).ToUpper() + str.Substring(5, str.Length - 5));
            else
                Console.WriteLine("Nothing");
        }
    }
}
