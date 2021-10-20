using NUnit.Framework;
using System;
using System.Runtime.Serialization;

namespace TDD_IPlyska
{
    [TestFixture]
    public class SquareEquationSolverTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, 0)]
        public void Solve_GivenIvalidData_ShouldThrowExeption(double a, double b, double c)
        {
            //assert
            SquareEquationSolver equation = new SquareEquationSolver();
            //act assert
            Assert.That(() => equation.Solve(a, b, c), Throws.TypeOf<ArgumentException>().With.Property("Message").EqualTo("Arguments can not be equals zero."));
        }

        [TestCase(0, 2, 3)]
        [TestCase(2, 2, 0)]
        public void Solve_Given_A_Zero_Should_Have_One_Root(double a, double b, double c)
        {
            //assert
            SquareEquationSolver equation = new SquareEquationSolver();

        }

        [Test]
        public void Solve_Check_When_Discriminant_Equal_Zero(double a, double b, double c)
        {
            //assert
            SquareEquationSolver equation = new SquareEquationSolver();
            Assert.Pass();
        }

    }

    internal class SquareEquationSolver
    {
        internal EquationRoots Solve(double a, double b, double c)
        {
            EquationRoots equation;
            ParametersValidation(a, b, c);


            return new EquationRoots();
        }

        private static void ParametersValidation(double a, double b, double c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Arguments can not be equals zero.");
            }

           
        }

        private static EquationRoots OneParameterIsZero(double a, double b, double c, out bool status)
        {
            if (a == 0 && b != 0 && c != 0)
            {
                status = true;
                return new EquationRoots() { R1 = -c / b , R2 = null};
            }

            if (a != 0 && b == 0 && c != 0)
            {
                status = true;

                return new EquationRoots() { R1 = Math.Round(Math.Sqrt(-c / a), 5), R2 = null };
            }

            if (a != 0 && b != 0 && c == 0)
            {
                status = true;
                return new EquationRoots() { R1 = 0, R2 = Math.Round(-b / a, 5) };

            }
            status = false;
            return new EquationRoots();
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

        public NoRootsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoRootsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}