using System;

namespace Task2_Decorator
{
    class WorkPC : IPC
    {
        public void AssembleSystemBlock()
        {
            Console.WriteLine("Assembled System Block for Work PC. Installed 32Gb RAM, Intel i7");
        }

        public void SetAccessories()
        {
            Console.WriteLine("Added Wireless Keyboard and Mouse for Work PC");
        }

        public void SetMonitor()
        {
            Console.WriteLine("Added monitor Dell S2240L 23\"");
        }
    }
}
