using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Collector collector = new Collector();
            Compiler compiler = new Compiler();
            TextEditor textEditor = new TextEditor();

            FacadeForTool facade = new FacadeForTool(collector, compiler, textEditor);

            facade.CompileAndGetFinialOutput();
        }
    }
}
