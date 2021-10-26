using System;
using System.IO;

namespace SquareEquation
{
    class SquareEquationSolver
    {
        ILogger _logger;

        public SquareEquationSolver() : this(new Logger()) {}

        public SquareEquationSolver(ILogger logger)
        {
            _logger = logger;
        }

        public EquationSolution Solve(double a, double b, double c)
        {
            double root1 = double.NaN;
            double root2 = double.NaN;

            CheckOnZero(a);
            double D = GetSqrtDiscriminant(a, b, c);

            if(D > 0)
            {
                root1 = (-b + D) / (2 * a);
                root2 = (-b - D) / (2 * a);
            }

            if(D == 0)
            {
                root1 = -b / 2 * a;
            }

            return new EquationSolution(root1, root2);
        }

        public void SaveResult(EquationSolution solution, string path)
        {
            string content = "";

            if(double.IsNaN(solution.Root1) && double.IsNaN(solution.Root2))
            {
                content = "<No solution>";
            }
            else if(double.IsNaN(solution.Root2))
            {
                content = $"<Root #1: {solution.Root1}>";
            }
            else
            {
                content = $"<Root #1: {solution.Root1}; Root #2: {solution.Root2}>";
            }

            File.WriteAllText(path, content);
        }

        public void SolveAndSaveSolution(double a, double b, double c, string filePath)
        {
            EquationSolution result = Solve(a, b, c);
            SaveResult(result, filePath);
        } 

        private double GetSqrtDiscriminant(double a, double b, double c)
        {
            return Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
        }

        private void CheckOnZero(double a)
        {
            if(a == 0)
            {
                _logger.Log("\'A\' cannot be zero, otherwise it is a linear equation!", MessageType.Error);
                throw new ArgumentException("\'A\' cannot be zero, otherwise it is a linear equation!");
            }
        }
    }

}