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
        public static IFileWrapper FileWrapper { get; set; } = new FileWrapper();

        public void SaveResult(Roots roots, string filePath)
        {
            FileWrapper.CheckIfExists(filePath);

            if (roots.Root1 == null && roots.Root2 == null)
            {
                FileWrapper.WriteTextInFile(filePath, "<No solution>");
            }
            else if (roots.Root1 == roots.Root2)
            {
                FileWrapper.WriteTextInFile(filePath, $"<Root #1: {roots.Root1}>");
            }
            else
            {
                FileWrapper.WriteTextInFile(filePath, $"<Root #1: {roots.Root1}; Root #2: {roots.Root2}>");
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
                roots = new Roots(null, null);
            }
            finally
            {
                SaveResult(roots, filePath);
            }
        }
    }
}
