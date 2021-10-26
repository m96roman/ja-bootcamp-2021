using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveEquation
{
    public interface IFileWrapper
    {
        public void WriteToFile(string filePath, string result);
    }
}
