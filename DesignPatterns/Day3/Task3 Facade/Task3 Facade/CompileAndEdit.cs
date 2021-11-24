using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Facade
{
   public class CompileAndEdit
    {
        TextEditor TextEditor;
        Compiler Compiler;

        public CompileAndEdit(TextEditor textEditor, Compiler compiler)
        {
            Compiler = compiler;
            TextEditor = textEditor;
        }

        public void Start()
        {
            Compiler.Validate();
            Compiler.Complile();
            TextEditor.Save();
        }
    }
}
