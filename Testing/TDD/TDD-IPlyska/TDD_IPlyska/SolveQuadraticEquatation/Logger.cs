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
        public void SaveResult(EquationRoots roots, string path)
        {
            File.WriteAllText(path, roots.ToString());
        }
    }
}
