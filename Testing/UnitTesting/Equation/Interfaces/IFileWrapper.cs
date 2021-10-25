using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation.Interfaces
{
    public interface IFileWrapper
    {
        string ReadDataFromFile(string filePath);
        bool CheckFileExists(string filePath);
        void WriteDataIntofile(string filePath, string contents);
    }
}
