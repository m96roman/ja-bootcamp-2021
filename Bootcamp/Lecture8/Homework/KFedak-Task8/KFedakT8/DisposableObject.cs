using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakT8
{
    public class DisposableObject : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            disposed = true;

            Console.WriteLine("I was disposed=(");
        }
        public void DoSomething()
        {
            if (disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
            else
            {
                Console.WriteLine("I'm doing something important.");
            }
        }
    }
}
