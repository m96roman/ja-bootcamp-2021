using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveQuadraticEquatation
{
    internal class SquareEquationSolver
    {
        public string FilePath { get; } = $@"{Directory.GetCurrentDirectory()}\quadraticEquatation.txt";
        private readonly ILogger _logger; 

        public SquareEquationSolver()
        {
            _logger = new Logger();
        }

        public SquareEquationSolver(ILogger logger)
        {
            _logger = logger;
        }

        internal async Task<EquationRoots> SolveAsync(double a, double b, double c)
        {
          return await Task.Run(() =>
                {
                    ParametersValidation(a, b, c);

                    if (ParametersValidationForZero(a, b, c))
                    {
                        return new EquationRoots(0, 0);
                    }

                    return FindRoots(a, b, c);
                });

            //ParametersValidation(a, b, c);

            //if (ParametersValidationForZero(a, b, c))
            //{
            //    return new EquationRoots(0, 0);
            //}
             
            //return FindRoots(a, b, c);
        }

        private static EquationRoots FindRoots(double a, double b, double c)
        {
            return OneParameterIsZero(a, b, c) ?? FindRootsWithDiscriminant(a, b, c);
        }

        /// <summary>
        /// Method to check if Quadratic Equatation is correct
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        private static void ParametersValidation(double a, double b, double c)
        {
            if (AllParametersAreZero(a, b, c) || TwoParamAandBAreZero(a, b))
            {
                throw new ArgumentException("Arguments can not be equals zero.");
            }
        }

        private static bool TwoParamAandBAreZero(double a, double b)
        {
            return a == 0 && b == 0; 
        }

        private static bool AllParametersAreZero(double a, double b, double c)
        {
            return a == 0 && b == 0 && c == 0;
        }

        /// <summary>
        /// Method to check if a and c equals 0
        /// and b and c equal 0
        /// in that case roots quals 0
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method to find discriminant
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private static EquationRoots FindRootsWithDiscriminant(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                throw new NoRootsException();
            }

            if (discriminant == 0)
            {
                return new EquationRoots(Round(-b / (2 * a)));
            }

            return new EquationRoots()
            {
                R1 = Round((-b + Math.Sqrt(discriminant)) / 2 * a),
                R2 = Round((-b - Math.Sqrt(discriminant)) / 2 * a)
            };
        }

        /// <summary>
        /// Method to check when Quadratic Equatation is not full
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="foundRoots"></param>
        /// <returns></returns>
        private static EquationRoots? OneParameterIsZero(double a, double b, double c)
        {
            if (a == 0) { return new EquationRoots(Round(-c / b)); }

            if (b == 0)
            {
                if (-c / a > 0)
                {
                    double root = Round(Math.Sqrt(-c / a));
                    return new EquationRoots(root, -root);
                }

                throw new NoRootsException();
            }

            if (c == 0) { return new EquationRoots(0, Round(-b / a)); }

            return null;
        }

        private static double Round(double root)
        {
            return Math.Round(root, 10);
        }

        public async Task SolveAndSaveSolutionAsync(double a, double b, double c, string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException(filePath);
            }

            try
            {
                var roots = await SolveAsync(a, b, c);
                if (roots.R1 != null && roots.R2 == null)
                {
                    _logger.SaveResult($"<Root #1: {roots.R1}>", filePath);
                    return;
                }

                _logger.SaveResult(roots.ToString(), filePath);
            }
            catch (ArgumentException ex)
            {
                _logger.SaveResult("<No solution>", filePath);
            }
            catch (NoRootsException ex)
            {
                _logger.SaveResult("<No solution>", filePath);
            }
        }
    }
}
