using System;

namespace VDedenok_Task8
{   
    class DisposableObject : IDisposable
    {
        bool disposed { get; set; } = false;

        public void DoSomething()
        {
            if (disposed)
            {
                throw new NotImplementedException();
            }
            else
            {
                Console.WriteLine("I'm doing something important.");
            }
        }

        public void Dispose()
        {
            if (disposed)
            {
                Console.WriteLine("I was disposed =(");
            }
            else
            {
                disposed = true;
            }
        }
    }
}
