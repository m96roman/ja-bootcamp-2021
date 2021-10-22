using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSquareEquation
{
    public interface IFileWrapper
    {
        bool CheckIfExists(string filePath);
        string ReadTextInFile(string filePath);
    }
}
