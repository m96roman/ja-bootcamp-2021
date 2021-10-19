using System;
using Task1.Extensions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Visual", "Use", "Try", "ask", "World", "Question" };

            words = words.Filter(it => !string.IsNullOrEmpty(it) && char.IsUpper(it[0]));

            Console.WriteLine("Strings started from UpperCase: ");
            foreach(var item in words)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Length:");
            Console.WriteLine(words.Map(it => it.Length));
        }
    }
}
