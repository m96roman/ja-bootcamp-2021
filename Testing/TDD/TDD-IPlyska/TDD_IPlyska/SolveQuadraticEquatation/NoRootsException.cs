using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveQuadraticEquatation
{
    internal class NoRootsException : Exception
    {
        public NoRootsException()
        {
        }

        public NoRootsException(string message) : base(message)
        {
        }

    }
}
