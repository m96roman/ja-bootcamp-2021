using System;

namespace SquereEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class EquationSolver
    {
        public EquationRoots Solver(int a, int b, int c)
        {
            return Solve(a, b, c);
        }

        internal EquationRoots Solve(int a, int b, int c)
        {
            var determinant = CalculateDeterminant(a, b, c);

            if (determinant == null)
            {
                throw new NoRootsException();
            }

            if (determinant == 0)
            {
                return FindRoots(a, b, c);
            }

            if (determinant > 0)
            {
                return FindRoots(a, b, c);
            }

            return new EquationRoots();

        }

        private static EquationRoots FindRoots(int a, int b, int c)
        {
            var determinant = CalculateDeterminant(a, b, c);

            return new EquationRoots
            {
                R1 = (-b + determinant) / (2 * a),
                R2 = (-b - determinant) / (2 * a)
            };
        }

        private static double? CalculateDeterminant(int a, int b, int c)
        {
            if (b * b - 4 * a * c < 0)
            {
                return null;
            }
            return Math.Sqrt(b * b - 4 * a * c);
        }
    }

    public struct EquationRoots
    {
        public double? R1 { get; set; }
        public double? R2 { get; set; }
    }

    public class NoRootsException : Exception
    {
    }
}
