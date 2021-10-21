using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSquareEquation
{
    class Solver
    {
        public void SolveAndSave(double a, double b, double c)
        {
            SquareEquation equation = new();
            double discriminant = equation.FindDiscriminant(a, b, c);

            using (StreamWriter streamWriter = new("Solution.txt"))
            {
                if (discriminant > 0)
                {
                    Roots solution = equation.SquareEquationTwoRoots(a, b, c);
                    streamWriter.Write($"Root #1: {solution.Root1}; Root #2: {solution.Root2}");
                }
                else if (discriminant == 0)
                {
                    Roots solution = equation.SquareEquationOneRoot(a, b, c);
                    streamWriter.Write($"Root #1: {solution.Root1}");
                }
                else
                {
                    streamWriter.Write($"<No solution>");
                }
            }
        }
    }
}
