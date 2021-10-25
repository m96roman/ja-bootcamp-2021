using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSquareEquation
{
    public class FileWrapper : IFileWrapper
    {
        public bool CheckIfExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public string ReadTextInFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public void WriteTextInFile(string filePath, string message)
        {
            File.WriteAllText(filePath, message);
        }
    }
}
