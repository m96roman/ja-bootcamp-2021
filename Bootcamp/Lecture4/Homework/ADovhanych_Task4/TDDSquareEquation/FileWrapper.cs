using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSquareEquation
{
    internal class FileWrapper : IFileWrapper
    {
        public bool CheckIfExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public string ReadTextInFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
