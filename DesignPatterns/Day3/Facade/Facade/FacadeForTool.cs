using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class FacadeForTool
    {
        private Collector _collector;
        private Compiler _compiler;
        private TextEditor _text;

        public FacadeForTool(Collector collector, Compiler compiler, TextEditor text)
        {
            this._compiler = compiler;
            this._collector = collector;
            this._text = text;
        }

        public void CompileAndGetFinialOutput()
        {
            _compiler.CompileCode();
            _collector.FinilizeFormatingLibraries();
        }
    }
}
