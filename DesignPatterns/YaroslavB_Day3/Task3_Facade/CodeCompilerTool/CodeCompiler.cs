using System;

namespace Task3_Facade
{
    class CodeCompiler
    {
        public bool ValidateSourceCode(string pathToSourceCode)
        {
            Random rd = new Random();
            bool result = rd.Next(2) == 1;
            Console.WriteLine($"Code by \'{pathToSourceCode}\' has been validated, result: {result}");
            return result;
        }

        public void CompileCodeToBinaryFiles(string pathToSourceCode, string workDirectoryPath)
        {
            Console.WriteLine($"Source code compiled to binary files, located in work folder: {workDirectoryPath}");
        }
    }
}
