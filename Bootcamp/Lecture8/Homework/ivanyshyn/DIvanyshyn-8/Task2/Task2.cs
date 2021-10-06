using System;

namespace DIvanyshyn_8.DisposableExample
{
    internal class Task2
    {
        internal static void Execute()
        {
            DisposableObject obj = new();
            obj.DoSomething();
            try
            {
                obj.Dispose();
                obj.DoSomething();
            }
            catch (ObjectDisposedException odE)
            {
                Console.WriteLine(odE);
            }
        }
    }
}