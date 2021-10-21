using System;
using System.Runtime.Serialization;

namespace Equation

{
    [Serializable]
    public class NoSolution : Exception
    {
        public QuadraticFunction QuadraticFunction { get; }

        public NoSolution()
        {
        }

        public NoSolution(QuadraticFunction quadraticFunction, string message) : base(message)
        {
            QuadraticFunction = quadraticFunction;
        }

        public NoSolution(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSolution(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}