using System;

namespace EquationUnitTest

{
    internal class QuadraticFunction
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public QuadraticFunction(double v1, double v2, double v3)
        {
            this.A = v1;
            this.B = v2;
            this.C = v3;
        }

        internal Result DeltaBiggerThanZero(double v1, double v2)
        {
            var x1 = (-B - Math.Sqrt(CalculateDelta())) / 2 * A;
            var x2 = (-B + Math.Sqrt(CalculateDelta())) / 2 * A;

            return new Result(x1, x2);
        }

        internal Result DeltaEqualZero(double a, double b)
        {
            var root = (-b) / 2 * a;

            return new Result(root, root);
        }

        internal double CalculateDelta()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }

        internal Result Slove()
        {
            var delta = CalculateDelta();

            if (delta < 0)
            {
                throw new NoSolution(this, "Determinate < 0.\n No solution");
            }
            else if (delta == 0)
            {
                return DeltaEqualZero(A, B);
            }
            else
            {
                return DeltaBiggerThanZero(A, B);
            }
        }
    }
}