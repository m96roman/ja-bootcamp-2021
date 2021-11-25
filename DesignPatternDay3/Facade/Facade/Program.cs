using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextRedactor redactor = new TextRedactor();
            Compiler compiler = new Compiler();
            Collector collector = new Collector();

            Facade useFacade = new Facade(redactor, compiler, collector);
            useFacade.GetCompiledDocument();
        }
    }
}
