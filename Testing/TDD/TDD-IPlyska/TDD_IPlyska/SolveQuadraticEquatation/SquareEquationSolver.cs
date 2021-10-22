using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveQuadraticEquatation
{
    internal class SquareEquationSolver
    {
        internal EquationRoots Solve(double a, double b, double c)
        {
            bool status = false;
            EquationRoots equation;
            ParametersValidation(a, b, c);

            if (ParametersValidationForZero(a, b, c))
            {
                return new EquationRoots() { R1 = 0, R2 = 0 };
            }
            equation = OneParameterIsZero(a, b, c, out status);

            if (status)
            {
                return equation;
            }
            else
            {
                return FindDiscriminant(a, b, c);
            }
        }

        private static void ParametersValidation(double a, double b, double c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Arguments can not be equals zero.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Arguments can not be equals zero.");
            }

        }

        private static bool ParametersValidationForZero(double a, double b, double c)
        {
            bool status = false;

            if (a == 0 && c == 0)
            {
                status = true;
            }

            if (b == 0 && c == 0)
            {
                status = true;
            }

            return status;
        }


        private static EquationRoots FindDiscriminant(double a, double b, double c)
        {
            EquationRoots equation;
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new NoRootsException();
            }

            if (discriminant > 0)
            {
                return equation = new EquationRoots()
                {
                    R1 = Math.Round((-b + Math.Sqrt(discriminant)) / 2 * a, 10),
                    R2 = Math.Round((-b - Math.Sqrt(discriminant)) / 2 * a, 10),
                };
            }

            if (discriminant == 0)
            {
                return equation = new EquationRoots()
                {
                    R1 = Math.Round(-b / (2 * a), 10),
                };
            }

            return new EquationRoots();
        }

        private static EquationRoots OneParameterIsZero(double a, double b, double c, out bool status)
        {
            if (a == 0 && b != 0 && c != 0)
            {
                status = true;
                return new EquationRoots() { R1 = Math.Round(-c / b, 10), R2 = null };
            }

            if (a != 0 && b == 0 && c != 0)
            {
                status = true;

                if (-c / a > 0)
                {
                    return new EquationRoots() { R1 = Math.Round(Math.Sqrt(-c / a), 10), R2 = -Math.Round(Math.Sqrt(-c / a), 10) };
                }

                throw new NoRootsException();
            }

            if (a != 0 && b != 0 && c == 0)
            {
                status = true;
                return new EquationRoots() { R1 = 0, R2 = Math.Round(-b / a, 10) };
            }

            status = false;
            return new EquationRoots() { R1 = null, R2 = null };
        }
    }
}
