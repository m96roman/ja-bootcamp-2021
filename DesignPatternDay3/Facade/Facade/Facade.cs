using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        TextRedactor redactor;
        Compiler compiler;
        Collector collector;

        public Facade(TextRedactor redactor, Compiler compiler, Collector collector)
        {
            this.redactor = redactor;
            this.compiler = compiler;
            this.collector = collector;
        }

        public void GetCompiledDocument()
        {
            compiler.Compile();
            collector.FormatDocumentLibrary();
        }
    }
}
