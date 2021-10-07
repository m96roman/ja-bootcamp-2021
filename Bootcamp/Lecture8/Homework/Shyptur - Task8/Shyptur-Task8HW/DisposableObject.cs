using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur_Task8HW
{
    class DisposableObject : IDisposable
    {
        private bool isDisposed;

        public DisposableObject()
        {
            isDisposed = true;
        }

        public void Dispose()
        {
            Console.WriteLine("I was disposed = (");
            isDisposed = false;
        }

        public void DoSomething()
        {
            if (isDisposed)
            {
                Console.WriteLine("I'm doing something important.");
            }
            else
            {
                throw new ObjectDisposedException("I was disposed ");
            }
        }
    }
}
