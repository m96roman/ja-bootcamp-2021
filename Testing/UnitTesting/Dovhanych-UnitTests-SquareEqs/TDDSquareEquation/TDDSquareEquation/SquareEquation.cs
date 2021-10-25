using System;

namespace TDDSquareEquation
{
    internal class SquareEquation
    {
        internal double FindDiscriminant(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            return discriminant;
        }

        internal Roots SquareEquationTwoRoots(double a, double b, double d)
        {
            double firstRoot = (-b + Math.Sqrt(d)) / (2 * a);
            double secondRoot = (-b - Math.Sqrt(d)) / (2 * a);

            return new Roots(firstRoot, secondRoot);
        }

        internal Roots SquareEquationOneRoot(double a, double b, double c)
        {
            double similarRoots = -b / (2.0 * a);

            return new Roots(similarRoots, similarRoots);
        }

        internal Roots SquareEquationSolution(double a, double b, double c)
        {
            double discriminant = FindDiscriminant(a, b, c);

            if (discriminant > 0)
            {
                return SquareEquationTwoRoots(a, b, c);
            }
            else if (discriminant == 0)
            {
                return SquareEquationOneRoot(a, b, c);
            }
            else
            {
                throw new NoRootsException("There is no solution for this equation");
            }
        }
    }
}
