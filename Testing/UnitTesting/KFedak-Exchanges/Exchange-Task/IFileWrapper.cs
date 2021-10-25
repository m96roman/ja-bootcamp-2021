using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Task
{
    public interface IFileWrapper
    {
        string ReadDataFromFile(string filePath);
        bool CheckFileExists(string filePath);
        void WriteInFile(string filePath, string information);
    }
}
