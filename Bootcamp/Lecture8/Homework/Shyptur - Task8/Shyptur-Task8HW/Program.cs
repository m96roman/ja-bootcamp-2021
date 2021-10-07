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

            //=====================Task 2=====================
            var disposableObjectExample = new DisposableObject();
            disposableObjectExample.DoSomething();
            disposableObjectExample.Dispose();

            try
            {
                disposableObjectExample.DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
