using Facade.HightMatery.Assemblies1;
using Facade.HightMatery.Compiler;
using Facade.View;
using HighMatery;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ITextRedactor textRedactor = new TextRedactor();
            textRedactor.Save();

            IBuilderCompiler builderCompiler = new BuilderCompiler(new CSharpCompiler(), new Assembly());

            builderCompiler.RunDebug();
        }
    }
}
