using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    internal interface IFileWorker
    {
        void WriteInFile(string filePath, string message);

        public string ReadDataFromFile(string filePath);

        public bool CheckFileExists(string filePath);
    }
}
