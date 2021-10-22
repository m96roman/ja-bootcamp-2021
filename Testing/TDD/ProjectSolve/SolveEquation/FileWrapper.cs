using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveEquation
{
  public  class FileWrapper : IFileWrapper
    {
        public void WriteToFile(string filePath, string result)
        {
            if (!File.Exists(filePath))
            {
                File.AppendAllText(filePath, result);
            }
            else
            {
                File.Delete(filePath);
                File.AppendAllText(filePath, result);
            }
        }
    }
}
