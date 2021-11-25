using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private Compiler Compiler { get; set; }
        private TextEditor TextEditor { get; set; }
        private Collector Collector { get; set; }

        public Facade(Compiler compiler, TextEditor textEditor, Collector collector)
        {
            this.Compiler = compiler;
            this.TextEditor = textEditor;
            this.Collector = collector;
        }

        public void Run() 
        {
            Compiler.Validate();
            Compiler.Compile();
            Collector.CopyIntoFolder();
        }
    }
}
