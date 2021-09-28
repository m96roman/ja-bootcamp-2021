using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string -> ");
            string entredString = Console.ReadLine();

            char[] ch = entredString.ToCharArray();

            Console.WriteLine(entredString[entredString.Length - 1] + entredString.Substring(1, entredString.Length - 2) + entredString[0].ToString());
        }
    }
}
