using System;

namespace Equation.Exceptions
{
    public class NoRootsException : Exception
    {
        public NoRootsException() { }

        public NoRootsException(string message) : base(message) { }
    }
}
