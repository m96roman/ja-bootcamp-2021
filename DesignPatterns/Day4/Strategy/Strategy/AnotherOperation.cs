using System;

namespace Strategy
{
    public class AnotherOperation : IOperation
    {
        public void Execute(string message)
        {
            Console.WriteLine($"Receives {message}");
            Console.WriteLine("Started alternate execution");
        }
    }
}