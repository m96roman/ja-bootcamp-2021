using Facade.HightMatery;
using Facade.HightMatery.Assemblies1;
using Facade.HightMatery.Compiler;
using System;

namespace HighMatery
{
    internal class BuilderCompiler : IBuilderCompiler
    {
        private readonly ICompiler compiler;

        private readonly IAssembly assembly;

        public BuilderCompiler(ICompiler compiler, IAssembly assembly)
        {
            this.compiler = compiler;

            this.assembly = assembly;
        }

        public void RunDebug()
        {
            compiler.Compile();

            assembly.BuildAssembly(compiler.Validate());
        }
    }
}