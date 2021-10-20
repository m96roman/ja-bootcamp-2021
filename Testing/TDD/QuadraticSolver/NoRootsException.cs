using System;
using System.Runtime.Serialization;

namespace QuadraticSolver
{
    [Serializable]
    internal class NoRootsException : Exception
    {
        public NoRootsException()
        {
        }

        public NoRootsException(string message) : base(message)
        {
        }

        public NoRootsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoRootsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}