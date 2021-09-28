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

            char temp = ch[0];
            ch[0] = ch[ch.Length - 1];
            ch[ch.Length - 1] = temp;

            Console.WriteLine(ch);
        }
    }
}
