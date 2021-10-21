using NUnit.Framework;
using System;
using System.Runtime.Serialization;

namespace TDD_IPlyska
{
    [TestFixture]
    public class SquareEquationSolverTest
    {
        SquareEquationSolver equation;
        [SetUp]
        public void Setup()
        {
            equation = new SquareEquationSolver();
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 0, 2)]
        [TestCase(2, 0, 0)]
        public void Solve_GivenIvalidData_ShouldThrowExeption(double a, double b, double c)
        {
            //arrange
            //act assert
            Assert.That(() => equation.Solve(a, b, c), Throws.TypeOf<ArgumentException>().With.Property("Message").EqualTo("Arguments can not be equals zero."));
        }

        [TestCase(0, 3, 0, 0)]
        [TestCase(2, 0, 0, 0)]
        public void Solve_Given_Two_Zero_Values(double a, double b, double c, double expectedValue)
        {
            EquationRoots roots = equation.Solve(a, b, c);
            //assert
            Assert.That(roots.R1, Is.EqualTo(expectedValue));
            Assert.That(roots.R2, Is.EqualTo(expectedValue));
        }

        [TestCase(0, 2, 3, -1.5)]
        [TestCase(0, 2, -4, 2)]
        [TestCase(0, -20, -4, -0.2)]
        [TestCase(0, -20.3, -4.9, -0.2413793103)]
        public void Solve_Given_A_Zero_Should_Have_One_Root(double a, double b, double c, double expectedValue)
        {
            //arrange
            //act
            EquationRoots roots = equation.Solve(a, b, c);
            //assert
            Assert.That(roots.R1, Is.EqualTo(expectedValue));
            Assert.That(roots.R2, Is.EqualTo(null));
        }

        [TestCase(-2, -4.5, 0, -2.25)]
        [TestCase(-20.08, -4.58, 0, -0.2280876494)]
        [TestCase(31.4, -41.5, 0, 1.321656051)]
        public void Solve_Given_C_Zero_Have_Two_Roots(double a, double b, double c, double expectedValue)
        {
            //act
            EquationRoots roots = equation.Solve(a, b, c);
            //assert
            Assert.That(roots.R2, Is.EqualTo(expectedValue));
            Assert.That(roots.R1, Is.EqualTo(0));
        }

        [TestCase(-4.67, 0, 22, 2.1704655655)]
        [TestCase(9.67, 0, -2.99, 0.5560608985)]
        public void Solve_Given_B_Zero_One_Way_With_Roots(double a, double b, double c, double expectedValue)
        {
            //act
            EquationRoots roots = equation.Solve(a, b, c);
            //assert
            Assert.That(roots.R1, Is.EqualTo(expectedValue));
            Assert.That(roots.R2, Is.EqualTo(-expectedValue));
        }

        [TestCase(-4, 0, -5)]
        [TestCase(44, 0, 15)]
        [TestCase(0.4564, 0, 0.3335)]
        public void Solve_Given_B_Zero_One_Way_With_NoRoots_Should_Throw_Exception(double a, double b, double c)
        {
            //act
            //arrange
             Assert.That(() => equation.Solve(a, b, c), Throws.TypeOf<NoRootsException>());
        }

        [TestCase(2.2, 6, 3, -3.1917746553, -10.0082253447)]
        [TestCase(-5.6, 2.22, 1.24, -9.7965730599, 22.2285730599)]
        public void Solve_If_Discriminant_More_Than_Zero(double a, double b, double c, double r1, double r2)
        {
            //act
            EquationRoots roots = equation.Solve(a, b, c);
            //assert
            Assert.That(roots.R1, Is.EqualTo(r1));
            Assert.That(roots.R2, Is.EqualTo(r2));
        }

        [TestCase(1.1, 5, 77)]
        [TestCase(10, 0.99999, 7)]
        [TestCase(0.55, 2.4, 3.3)]
        public void Solve_If_Discriminanrt_Less_Than_Zero_Shold_Throw_Exception(double a, double b, double c)
        {
            //arrange
            Assert.That(() => equation.Solve(a, b, c), Throws.TypeOf<NoRootsException>());
        }

    }

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

            if(a == 0 && c == 0)
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
                    R1 = Math.Round(-b / 2 * a, 10),
                    R2 = Math.Round(-b / 2 * a, 10),
                };
            }

            return new EquationRoots();
        }

        private static EquationRoots OneParameterIsZero(double a, double b, double c, out bool status)
        {
            if (a == 0 && b != 0 && c != 0)
            {
                status = true;
                return new EquationRoots() { R1 = Math.Round(-c / b, 10) , R2 = null};
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
            return new EquationRoots() {R1 = null, R2 = null};
        }

    }

    internal struct EquationRoots
    {
        public double? R1 { get; set; }
        public double? R2 { get; set; }
        public override string ToString() => $"Root #1: {R1}; Root #2: {R2}";

        public EquationRoots(double? r1 , double? r2 )
        {
            R1 = r1;
            R2 = r2;
        }

    }

    public class NoRootsException : Exception
    {
        public NoRootsException()
        {
        }

        public NoRootsException(string message) : base(message)
        {
        }

    }
}