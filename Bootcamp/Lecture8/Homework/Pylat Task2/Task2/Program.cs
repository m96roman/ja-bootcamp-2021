using System.IO;
using Task2;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DisposableObject p = new DisposableObject();
            try
            {
                using (p)
                {
                    p.DoSomething();
                }

                p.DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exeption!!! - {ex.Message}");
            }
        }
    }
}

