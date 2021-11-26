using System;

namespace Task3_Facade
{
    class CodeRedactor
    {
        public void SaveCode(string code, string path)
        {
            Console.WriteLine($"Code saved by path: \'{path}\'");
        }
    }
}
