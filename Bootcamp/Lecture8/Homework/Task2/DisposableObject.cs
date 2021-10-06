using System;

namespace Task2
{
    public class DisposableObject : IDisposable
    {
        private bool IsDisposed { get; set; }

        public DisposableObject()
        {
            IsDisposed = false;
        }

        public void Dispose()
        {
            IsDisposed = true;
            Console.WriteLine("I was disposed =(");
        }

        public void DoSomething()
        {
            if (IsDisposed)
            {
                throw new ObjectDisposedException("Object was disposed!");
            }
            else
            {
                Console.WriteLine("I'm doing something important.");
            }
        }
    }
}
