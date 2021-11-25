using System;

namespace Strategy
{
    public class PaintOperation : IOperation
    {
        public void Execute(string message)
        {
            Console.WriteLine($"Receives {message}");
            Console.WriteLine("Started painting");
        }
    }
}