using System;

namespace Facade
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var textEditor = new TextEditor();
            
            var compiller = new Compiller();
            
            var garbageCollector = new GarbageCollector();

            var visualStudioFacade = new VisualStudioFacade(textEditor, compiller, garbageCollector);

            var programmer= new Programmer();

            programmer.Create(visualStudioFacade);
        }
    }
}
