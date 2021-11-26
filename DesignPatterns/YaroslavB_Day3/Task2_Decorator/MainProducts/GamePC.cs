using System;

namespace Task2_Decorator
{
    class GamePC : IPC
    {
        public void AssembleSystemBlock()
        {
            Console.WriteLine("Assembled System Block for Game PC. Installed extra 8Gb RAM, 4Gb VideoCard");
        }

        public void SetAccessories()
        {
            Console.WriteLine("Added High-price Ultra-Sensitive Keyboard and Mouse for Game PC");
        }

        public void SetMonitor()
        {
            Console.WriteLine("Added monitor LG T500 27\"");
        }
    }
}
