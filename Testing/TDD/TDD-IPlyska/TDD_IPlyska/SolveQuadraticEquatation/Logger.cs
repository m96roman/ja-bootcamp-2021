using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveQuadraticEquatation
{
    internal class Logger : ILogger
    {
        public void SaveResult(string content, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException();
            }

            File.WriteAllText(path, content);
        }
    }
}
