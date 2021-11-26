using System;

namespace Task3_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var compiler = new CodeCompilerFacade();
            compiler.CreateFinalPackage("C:\\Projects\\CodeForCompiler.vbs", "C:\\Projects\\OutPutFolder");

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
