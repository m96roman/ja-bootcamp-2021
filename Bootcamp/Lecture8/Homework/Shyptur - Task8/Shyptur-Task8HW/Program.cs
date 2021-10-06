using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Shyptur_Task8HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 task1 = new Task1();
            //task1.task1();

            var memoryStreamWrapper = new DisposableObject();
            memoryStreamWrapper.DoSomething();
            memoryStreamWrapper.Dispose();
            try
            {
                memoryStreamWrapper.DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }
    class DisposableObject : IDisposable
    {
        private bool _object;

        public DisposableObject()
        {
            _object = true;
        }

        public void Dispose()
        {
            Console.WriteLine("I was disposed = (");
            _object = false;
        }

        public void DoSomething()
        {
            if (_object)
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
