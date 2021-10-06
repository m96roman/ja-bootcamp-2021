using System;

namespace DIvanyshyn_8.DisposableExample
{
    internal class DisposableObject : IDisposable
    {

        public bool IsDisposed { get; private set; }

        public DisposableObject()
        {
        }

        public void DoSomething()
        {
            if (IsDisposed)
            {
                throw new ObjectDisposedException("Test disposable object");
            }

            Console.WriteLine("I'm doing something important.");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine("I was disposed :(");
                }

                IsDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}