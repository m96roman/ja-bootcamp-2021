using System;

namespace Task3_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CompileAndEdit compileAndEdit = new CompileAndEdit(new TextEditor(), new Compiler());
            compileAndEdit.Start();
        }
    }
}
