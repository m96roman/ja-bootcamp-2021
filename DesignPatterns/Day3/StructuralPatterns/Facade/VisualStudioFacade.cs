using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
 internal   class VisualStudioFacade
 {
     private TextEditor TextEditor;
     private Compiller Compiller;
     private GarbageCollector GarbageCollector;

     public VisualStudioFacade(TextEditor textEditor, Compiller compiller, GarbageCollector garbageCollector)
     {
         TextEditor = textEditor;
         Compiller = compiller;
         GarbageCollector = garbageCollector;
     }

     public void Start()
     {
            Compiller.Compile();
            GarbageCollector.CopyToFolder();
     }
 }
}
