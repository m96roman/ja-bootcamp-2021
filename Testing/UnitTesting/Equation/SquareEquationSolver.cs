using System;
using System.Runtime.CompilerServices;
using Equation.Exceptions;
using Equation.Interfaces;
using Equation.Models;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation
{
    public class SquareEquationSolver
    {
        public IFileWrapper Wrapper { get; set; } = new FileWrapper();

        public void SaveResults(Roots roots, string filePath)
        {
            Wrapper.CheckFileExists(filePath);

            if (roots.R1.HasValue && roots.R2.HasValue)
            {
                Wrapper.WriteDataIntofile(filePath, $"<Root #1: {roots.R1}; Root #2: {roots.R2}>");
            }
            else if (roots.R1.HasValue)
            {
                Wrapper.WriteDataIntofile(filePath, $"<Root #1: {roots.R1}>");
            }
            else
            {
                Wrapper.WriteDataIntofile(filePath, $"<No solution>");
            }
        }

        public void SolveAndSaveSolution(Coefficients coef, string filePath)
        {
            Roots roots = new Roots { R1 = null, R2 = null };
            try
            {
                roots = Solve(coef);
            }
            catch (NoRootsException ex)
            {
                roots = new Roots { R1 = null, R2 = null };
            }
            finally
            {
                SaveResults(roots, filePath);
            }
        }

        public Roots Solve(Coefficients coef)
        {
            SquareEquationSolver calc = new SquareEquationSolver();

            double? disc = calc.CalculateDiscriminant(coef);

            if (!disc.HasValue)
            {
                throw new NoRootsException(message: "No root! Discriminant < 0");
            }
            else
            {
                return calc.CalculateRoots(coef, disc);
            }
        }

        public double? CalculateDiscriminant(Coefficients coef)
        {
            var result = Math.Pow(coef.B, 2) - 4 * coef.A * coef.C;

            if(result < 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public Roots CalculateRoots(Coefficients coef, double? disc)
        {
            if(disc == 0)
            {
                double r = -coef.B / 2 * coef.A;
                return new Roots { R1 = r, R2 = null };
            }
            else
            {
                double r1 = Math.Round(( (-coef.B + Math.Sqrt(disc.Value)) / 2 * coef.A), 10);
                double r2 = Math.Round(( (-coef.B - Math.Sqrt(disc.Value)) / 2 * coef.A), 10);
                return new Roots { R1 = r1, R2 = r2 }; 
            }
        }
    }
}
