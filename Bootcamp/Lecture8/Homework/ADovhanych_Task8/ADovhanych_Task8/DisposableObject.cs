using System;
using System.IO;

namespace ADovhanych_Task8
{
    class DisposableObject : IDisposable
    {
        private bool isDisposed { get; set; }

        public DisposableObject()
        {
            isDisposed = true;
        }

        public void Dispose()
        {
            isDisposed = false;
            Console.WriteLine("I was disposed");
        }

        public void DoSomething()
        {
            if(isDisposed)
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
