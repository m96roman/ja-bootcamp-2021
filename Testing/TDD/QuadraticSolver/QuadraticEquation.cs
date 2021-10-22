using System;

namespace QuadraticSolver
{
    public class QuadraticEquation
    {
        public double A { get; internal set; }

        public double B { get; internal set; }

        public double C { get; internal set; }

        public Solution Solution { get; internal set; } = new Solution(TypesOfSolution.NoSolution, 0, 0);

        public ISolutionWriter Writer { get; internal set; } = new ToFIleSolutionWriter();

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        internal string GetInFormat()
        {
            string result;

            switch (Solution.SolutionType)
            {
                case TypesOfSolution.OneRoot:
                    result = string.Format("<A: {0}; B: {1}; C: {2}; Root #1: {3}>", A, B, C, Math.Round(Solution.Root1, 10));
                    break;
                case TypesOfSolution.TwoRealRoots:
                    result = string.Format("<A: {0}; B: {1}; C: {2}; Root #1: {3}; Root #2: {4}>", A, B, C, Math.Round(Solution.Root1, 10), Math.Round(Solution.Root2, 10));
                    break;
                default:
                    result = $"<{Solution.SolutionType}>";
                    break;
            }

            return result;
        }

        //Or display//
        public void WriteAndSolve(string filePath, bool append = false)
        {
            try
            {
                Solution = GetSolution();
            }
            catch (NoRootsException nR)
            {
                Solution.SolutionType = nR.WrongSolutionType;
            }
            finally
            {
                Writer.Write(GetInFormat(), filePath, append);
            }
        }

        internal Solution GetSolution()
        {
            if (A == 0)
            {
                throw new NoRootsException($"{nameof(A)} cannot be 0");
            }

            double D = GetDiscriminant(A, B, C);

            if (D < 0)
            {
                throw new NoRootsException($"Equation dont have real roots", TypesOfSolution.TwoImaginaryRoots);
            }

            double root1 = ((-B + Math.Sqrt(D)) / (2 * A));
            double root2 = ((-B - Math.Sqrt(D)) / (2 * A));

            TypesOfSolution type = TypesOfSolution.OneRoot;

            if (D > 0)
            {
                type = TypesOfSolution.TwoRealRoots;
            }

            return new Solution(type, root1, root2);
        }

        internal double GetDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }
    }
}
