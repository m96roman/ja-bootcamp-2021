using System;

namespace Task2_Decorator
{
    class OfficePC : IPC
    {  
        public void AssembleSystemBlock()
        {
            Console.WriteLine("Assembled System Block for Office PC");
        }

        public void SetAccessories()
        {
            Console.WriteLine("Added Low-price Keyboard and Mouse for Office PC");
        }

        public void SetMonitor()
        {
            Console.WriteLine("Added monitor Samsung SyncMaster 17\"");
        }
    }
}
