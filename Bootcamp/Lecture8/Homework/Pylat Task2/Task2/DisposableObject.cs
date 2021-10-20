using System;

namespace Task2
{
    public class DisposableObject : IDisposable
    {
        private bool IsDisposed = true;

        public void Dispose()
        {
            IsDisposed = false;
            Console.WriteLine("I was disposed =(");
        }

        public void DoSomething()
        {
            if (IsDisposed)
            {
                Console.WriteLine("I'm doing something important.");
            }
            else
            {
                throw new ObjectDisposedException("object was disposed");
            }
        }
    }
}
