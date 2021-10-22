using System;

namespace QuadraticSolver
{
    public class Solution
    {
        public Solution(TypesOfSolution typeOfSolution, double root1, double root2)
        {
            SolutionType = typeOfSolution;
            Root1 = root1;
            Root2 = root2;
        }

        public TypesOfSolution SolutionType { get; internal set; }

        public double Root1 { get; internal set; }

        public double Root2 { get; internal set; }
    }
}