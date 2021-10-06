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
        private MemoryStream disposableObject;

        private bool dispose= false; 

        public DisposableObject() 
        {
            disposableObject = new MemoryStream();
        }

        public void Dispose()
        {            
            Console.WriteLine($"I was disposed =(");
            dispose = true;
            disposableObject.Dispose();
        }

        public void DoSomething()
        {
            if (dispose)
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
