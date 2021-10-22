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
        internal static IFileWrapper FileWrapper { get; set; } = new FileWrapper();

        public void SaveResult(Roots roots, string filePath)
        {
            using (StreamWriter streamWriter = new(filePath))
            {
                if (roots == null)
                {
                    streamWriter.Write("<No solution>");
                }
                else if (roots.Root2 == roots.Root1)
                {
                    streamWriter.Write($"Root #1: {roots.Root1}");
                }
                else
                {
                    streamWriter.Write($"Root #1: {roots.Root1}; Root #2: {roots.Root2}"); ;
                }

                FileWrapper.CheckIfExists(filePath);
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
