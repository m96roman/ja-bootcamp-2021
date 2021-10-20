using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DisposableObject disObject = new DisposableObject();

            using (disObject)
            {
                disObject.DoSomething();               
            }

            try
            {
                disObject.DoSomething();
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
