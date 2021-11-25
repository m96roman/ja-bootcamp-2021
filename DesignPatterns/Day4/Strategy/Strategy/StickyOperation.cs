using System;

namespace Strategy
{
    public class StickyOperation : IOperation
    {
        public void Execute(string message)
        {
            Console.WriteLine($"Receives {message}");
            Console.WriteLine("Started doing something");
        }
    }
}