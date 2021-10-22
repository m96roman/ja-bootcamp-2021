using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveQuadraticEquatation
{
    public interface ILogger
    {
        void SaveResult(EquationRoots roots, string path);
    }
}
