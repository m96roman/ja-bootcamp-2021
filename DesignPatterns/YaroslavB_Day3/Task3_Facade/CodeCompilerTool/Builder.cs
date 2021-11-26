using System;

namespace Task3_Facade
{
    class Builder
    {
        public void BuildLibraries(string workDirectoryPath, string outputFolder)
        {
            Console.WriteLine($"Has been built set of libraries and stored to output folder: \'{outputFolder}\'");
        }
    }
}
