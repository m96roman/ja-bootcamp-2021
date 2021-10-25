using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MRoshko_Task8
{
    class DisposableObject : IDisposable
    {
        private MemoryStream DisposableObj { get; set; }

        private bool DisposeFlag { get; set; }

        public DisposableObject()
        {
            DisposableObj = new MemoryStream();

            DisposeFlag = false;
        }

        public void Dispose()
        {
            Console.WriteLine($"I was disposed =(");

            DisposeFlag = true;

            DisposableObj.Dispose();
        }

        public void DoSomething()
        {
            if (DisposeFlag)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
            else
            {
                Console.WriteLine("I'm doing something important.");
            }
        }
    }
}
