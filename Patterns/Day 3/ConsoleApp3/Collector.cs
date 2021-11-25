using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class Collector : ICollector
    {
        public void Collect()
        {
            Console.WriteLine("Collect final dll...");
        }

        public void CopyOutput()
        {
            Console.WriteLine("Coping...");
        }
    }
}
