using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade(
                new Compiler(),
                new TextEditor(),
                new Collector()
                );

            facade.Run();
        }
    }
}
