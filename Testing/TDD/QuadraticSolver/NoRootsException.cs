using System;
using System.Runtime.Serialization;

namespace QuadraticSolver
{
    [Serializable]
    internal class NoRootsException : Exception
    {
        public TypesOfSolution WrongSolutionType { get; private set; }

        public NoRootsException(string message, TypesOfSolution type = TypesOfSolution.NoSolution) : base(message)
        {
            WrongSolutionType = type;
        }
    }
}