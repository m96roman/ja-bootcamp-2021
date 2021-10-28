using System;

namespace Task2
{
    public class DisposableObject : IDisposable
    {
        bool Flag = true;

        public void Dispose()
        {
            Flag = false;
            Console.WriteLine("I was disposed =(");
        }

        public void DoSomething()
        {
            if (Flag == true)
            {
                Console.WriteLine("I'm doing something important.");
            }
            else throw new ObjectDisposedException("object was disposed");
        }
    }
}
