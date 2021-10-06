using System;

namespace DIvanyshyn_8.DisposableExample
{
    internal class DisposableObject : IDisposable
    {
        private bool isDisposed;

        public DisposableObject()
        {
        }

        public void DoSomething()
        {
            if (isDisposed)
            {
                throw new ObjectDisposedException("Test disposable object");
            }

            Console.WriteLine("I'm doing something important.");
        }

        public void Dispose()
        {
            Console.WriteLine("I was disposed :(");
            isDisposed = true;
        }
    }
}