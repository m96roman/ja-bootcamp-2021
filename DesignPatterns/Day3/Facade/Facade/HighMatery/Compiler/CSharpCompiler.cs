using System;

namespace Facade.HightMatery.Compiler
{
    class CSharpCompiler : ICompiler
    {
        public bool Validate()
        {
            Console.WriteLine("Your code is a burning pile of garbage!");

            Random random = new Random();

            return random.Next() % 2 == 0;
        }

        public void Compile()
        {
            Console.WriteLine("Compiling!");
        }
    }
}
