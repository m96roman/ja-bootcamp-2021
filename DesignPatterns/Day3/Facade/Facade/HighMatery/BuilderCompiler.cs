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

        public Library[] RunDebug()
        {
            compiler.Compile();

            return assembly.BuildAssembly(compiler.Validate());
        }
    }
}