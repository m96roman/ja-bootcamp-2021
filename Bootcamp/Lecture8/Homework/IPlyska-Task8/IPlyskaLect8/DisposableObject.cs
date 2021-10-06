using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect8
{
    public class DisposableObject : IDisposable
    {
        public bool IsDisposed { get; set; }
        public void Dispose()
        {
            Console.WriteLine("I was disposed =(");
            IsDisposed = true;
        }

        public void DoSomething()
        {
            Console.WriteLine("I'm doing something important."); 
        }
    }
}
