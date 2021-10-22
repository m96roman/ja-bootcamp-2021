using System.Runtime.CompilerServices;
using Equation.Interfaces;
using System.IO;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation
{
    public class FileWrapper : IFileWrapper
    {
        public bool CheckFileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public string ReadDataFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public void WriteDataIntofile(string filePath, string contents)
        {
            File.WriteAllText(filePath, contents);
        }
    }
}
