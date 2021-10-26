using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SolveQuadraticEquatation;
using System;

namespace SolveQuadraticEquatation.UnitTest
{
    [TestFixture]
    public class TestSquareEquationSolver
    {
        readonly SquareEquationSolver equation = new SquareEquationSolver();
        readonly Mock<ILogger> fileMock = new Mock<ILogger>();

        [TestCase(0, 0, 0)]
        [TestCase(0, 0, 2)]
        public void Solve_GivenIvalidData_ShouldThrowExeption(double a, double b, double c)
        {
            //arrange
            //act assert
            Assert.That(() => equation.Solve(a, b, c), Throws.TypeOf<ArgumentException>().With.Property("Message").EqualTo("Arguments can not be equals zero."));
        }

        [TestCase(0, 3, 0, 0)]
        [TestCase(2, 0, 0, 0)]
        public void Solve_Given_Two_Zero_Values_Should_Have_One_Root(double a, double b, double c, double expectedValue)
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

        [TestCase(-4, 0, -5)]
        [TestCase(44, 0, 15)]
        [TestCase(0.4564, 0, 0.3335)]
        [TestCase(1.1, 5, 77)]
        [TestCase(10, 0.99999, 7)]
        [TestCase(0.55, 2.4, 3.3)]
        public void Solve_If_Discriminanrt_Less_Than_Zero_Shold_Throw_Exception(double a, double b, double c)
        {
            //arrange
            Assert.That(() => equation.Solve(a, b, c), Throws.TypeOf<NoRootsException>());
        }

        [TestCase(2, 4, 2, -1)]
        [TestCase(2, 8, 8, -2)]
        [TestCase(5, -10, 5, 1)]
        public void Solve_If_Discriminant_Equal_Zero(double a, double b, double c, double r1)
        {
<<<<<<< HEAD
=======
            //act
            EquationRoots roots = equation.Solve(a, b, c);
>>>>>>> parent of 3ad01e9 (remade to await)
            //assert
            Assert.That(async () => (await equation.SolveAsync(a, b, c)).R1, Is.EqualTo(r1));
        }

        [TestCase(2, 3, 5, "")]
        [TestCase(4, 5, 7, null)]
        public void SolveAndSaveSolution_Given_Invalid_FilePath_Shold_Throw_Exception(double a, double b, double c, string filePath)
        {
            //assert
            Assert.That(() => equation.SolveAndSaveSolution(a, b, c, filePath), Throws.TypeOf<ArgumentException>());
        }

        [TestCase(2, 4, 2, "<Root #1: -1>")]
        [TestCase(-5.6, 2.22, 1.24, "<Root #1: -9,7965730599; Root #2: 22,2285730599>")]
        [TestCase(0, 0, 3, "<No solution>")]
        public void Save_Result_Check_Formatting_For_Output_Result(double a, double b, double c, string content)
        {
            //arrange
            SquareEquationSolver solver = new SquareEquationSolver(fileMock.Object);

            //act
<<<<<<< HEAD
            await solver.SolveAndSaveSolutionAsync(a, b, c, "file");
=======
            solver.SolveAndSaveSolution(a, b, c, "file");
>>>>>>> parent of 3ad01e9 (remade to await)

            //assert
            fileMock.Verify(x => x.SaveResult(content, "file"));
        }
    }
}