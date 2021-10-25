using System;

namespace SquareEquation
{
    class SquareEquationSolver
    {
        InputValues values;
        ILogger _logger;

        public SquareEquationSolver(InputValues values) : this(values, new Logger()) {}

        public SquareEquationSolver(InputValues values, ILogger logger)
        {
            this.values = values;
            _logger = logger;
        }

        public void CalculateRoots(out double root1, out double root2)
        {
            root1 = double.NaN;
            root2 = double.NaN;

            CheckOnZero();
            double D = GetDiscriminant();
            var dd = Math.Sqrt(D);

            if(D > 0)
            {
                root1 = (-values.B + dd) / (2 * values.A);
                root2 = (-values.B - dd) / (2 * values.A);
            }

            if(D == 0)
            {
                root1 = -values.B / 2 * values.A;
            }
        }

        private double GetDiscriminant()
        {
            return Math.Pow(values.B, 2) - 4 * values.A * values.C;
        }

        private void CheckOnZero()
        {
            if(values.A == 0)
            {
                _logger.Log("\'A\' cannot be zero, otherwise it is a linear equation!", MessageType.Error);
                throw new ArgumentException("\'A\' cannot be zero, otherwise it is a linear equation!");
            }
        }
    }

}