using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class Compiller : ICompiller
    {
        public void Compile()
        {
            Console.WriteLine("Compiling...");
        }

        public void Validate()
        {
            Console.WriteLine("Validating...");
        }
    }
}
