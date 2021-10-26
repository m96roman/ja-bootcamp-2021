﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Task
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

        public void WriteInFile(string filePath, string message)
        {
            File.WriteAllText(filePath, message);
        }
    }
}
