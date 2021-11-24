using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Facade
    {
        TextEditor textEditor;
        Compiller compiller;
        Cleaner cleaner;

        public Facade(TextEditor textEditor, Compiller compiller, Cleaner cleaner)
        {
            this.textEditor = textEditor;
            this.compiller = compiller;
            this.cleaner = cleaner;
        }
        public void Start()
        {
           
            textEditor.Save();
            compiller.Compile();
            cleaner.Сlean();
        }      
    }
}
