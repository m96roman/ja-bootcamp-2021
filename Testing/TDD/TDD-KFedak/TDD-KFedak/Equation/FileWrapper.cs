using System.IO;

namespace Equation
{
    public class FileWrapper : IFileWrapper
    {
        public string ReadDataFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public bool CheckFileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public void WriteInFile (string filePath,string message)
        {
            File.WriteAllText(filePath,message);
        }
    }
}