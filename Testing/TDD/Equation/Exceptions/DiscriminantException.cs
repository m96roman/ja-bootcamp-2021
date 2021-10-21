using System;

namespace Equation.Exceptions
{
    public class DiscriminantException : Exception
    {
        public DiscriminantException() { }

        public DiscriminantException(string message) : base(message) { }
    }
}
