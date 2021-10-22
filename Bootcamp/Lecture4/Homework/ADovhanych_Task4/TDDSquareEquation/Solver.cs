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
        public void SaveResult(Roots roots, string filePath)
        {
            using (StreamWriter streamWriter = new(filePath))
            {
                if (roots.Root1 != roots.Root2)
                {
                    streamWriter.Write($"Root #1: {roots.Root1}; Root #2: {roots.Root2}");
                }
                else if (roots.Root2 == roots.Root1)
                {
                    streamWriter.Write($"Root #1: {roots.Root1}");
                }
                else
                {
                    streamWriter.Write($"<No solution>");
                }
            }
        }
        
        public void SolveAndSave(double a, double b, double c, string filePath)
        {
            SquareEquation equation = new();
            Roots roots = new();

            try
            {
                roots = equation.SquareEquationSolution(a, b, c);
            }
            catch (NoRootsException)
            {

                roots = null;
            }
            finally
            {
                SaveResult(roots, filePath);
            }
        }

    }
}
