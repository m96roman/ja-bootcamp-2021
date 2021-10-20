using System;

namespace QuadraticSolver
{
    internal class Solver
    {
        internal static Solution GetSolution(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new NoRootsException($"{nameof(a)} cannot be 0");
            }

            double D = GetDiscriminant(a, b, c);
            if (D >= 0)
            {
                double root1 = ((-b + Math.Sqrt(D)) / (2 * a));
                double root2 = ((-b - Math.Sqrt(D)) / (2 * a));

                return new Solution(D > 0 ? TypesOfSolution.TwoRealRoots : TypesOfSolution.OneRoot,
                    root1, root2);
            }

            throw new NoRootsException($"Equation dont have real roots");
        }

        internal static double GetDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }
    }
}
