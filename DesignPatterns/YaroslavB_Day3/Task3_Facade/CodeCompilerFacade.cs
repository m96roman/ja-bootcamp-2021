using System;

namespace Task3_Facade
{
    class CodeCompilerFacade
    {
        private const string _tempWorkDirectory = "C:\\Temp";

        public void CreateFinalPackage(string pathToCode, string pathtoOutputFolder)
        {
            var codeCompiler = new CodeCompiler();
            bool result = codeCompiler.ValidateSourceCode(pathToCode);

            if(!result)
            {
                Console.WriteLine($"Exeption: Code by path \'{pathToCode}\' failed validation!");
                return;
            }

            codeCompiler.CompileCodeToBinaryFiles(pathToCode, _tempWorkDirectory);

            var builder = new Builder();
            builder.BuildLibraries(_tempWorkDirectory, pathtoOutputFolder);
        }
    }
}
