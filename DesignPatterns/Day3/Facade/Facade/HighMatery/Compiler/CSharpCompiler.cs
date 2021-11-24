using System;

namespace Facade.HightMatery.Compiler
{
    class CSharpCompiler : ICompiler
    {
        public bool Validate()
        {
            Console.WriteLine("Your code is a burning pile of garbage!");

            return false;
        }

        public void Compile()
        {
            Console.WriteLine("Compiling!");
        }
    }
}
