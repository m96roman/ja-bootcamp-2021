using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {   
            string someText = "Hello world";
            Console.WriteLine($"Variable name: {nameof(someText)}\nVariable value: {someText}");

        }
    }
}
