using System;
using System.Runtime.CompilerServices;

namespace SolveQuadraticEquatation
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareEquationSolver solver = new SquareEquationSolver();

            solver.SolveAndSaveSolution(4.5, 7.8, 3, "quadraticEquatation.txt");
        }
    }
}
