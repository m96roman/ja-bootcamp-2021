using System;
using System.IO;

namespace ADovhanych_Task8
{
    class DisposableObject : IDisposable
    {
        public bool Memory { get; set; }

        public DisposableObject()
        {
            Memory = true;
        }

        public void Dispose()
        {
            Memory = false;
            Console.WriteLine("I was disposed");
        }

        public void DoSomething()
        {
            if(Memory)
            {
                Console.WriteLine("Doing something important");
            }
            else
            {
                throw new ObjectDisposedException("Disposed object");
            }
        }
    }
}
