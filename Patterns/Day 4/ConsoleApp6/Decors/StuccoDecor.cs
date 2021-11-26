using System;
using ConsoleApp6.Interfaces;

namespace ConsoleApp6.Decors
{
    public class StuccoDecor : IDecorate
    {
        public void Decorate()
        {
            Console.WriteLine("Expert apply stucco");
        }
    }
}
