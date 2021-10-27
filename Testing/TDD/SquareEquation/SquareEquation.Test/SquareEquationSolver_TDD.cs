using System;
using NUnit.Framework;
using Moq;

namespace SquareEquation.Test
{
    [TestFixture]
    public class SquareEquationSolver_TDD
    {

        private SquareEquationSolver GetTestInstance()
        {
            return new SquareEquationSolver();
        }

        private SquareEquationSolver GetTestInstanceWithLoggermock(out Mock<ILogger> loggerMock)
        {
            loggerMock = new Mock<ILogger>();
            return new SquareEquationSolver(loggerMock.Object);
        }

        [Test]
        public void Solve_Given_A_IsZero_ShouldThrowsException()
        {
            //arrange
            SquareEquationSolver instance = GetTestInstance();

            //act & assert
            Assert.Throws<ArgumentException>(() => instance.Solve(0, 1, 1));
        }

        [TestCase("\'A\' cannot be zero, otherwise it is a linear equation!")]
        public void Solve_Given_A_IsZero_ShouldThrowsExceptionMessage(string errorMsg)
        {
            //arrange
            SquareEquationSolver instance = GetTestInstance();

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => instance.Solve(0, 1, 1));

            //assert
            Assert.That(ex.Message, Is.EqualTo(errorMsg));
        }

        [TestCase(1 ,3, 2, -1, -2)]
        [TestCase(1, -6, 0, 6, 0)]
        [TestCase(-6, 12, 5, -0.3540, 2.3540)]
        public void Solve_GivenCoefficients_ShouldReturnCorrectRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            //arrange
            SquareEquationSolver instance = GetTestInstance();

            //act
            EquationSolution values = instance.Solve(a, b, c);

            //assert
            Assert.AreEqual(expectedRoot1, Math.Round(values.Root1, 4));
            Assert.AreEqual(expectedRoot2, Math.Round(values.Root2, 4));
        }

        [TestCase(1, 2, 1, -1, double.NaN)]
        public void Solve_GivenCoefficients_ShouldReturn_OnlyOneRoot(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            //arrange
            SquareEquationSolver instance = GetTestInstance();

            //act
            EquationSolution values = instance.Solve(a, b, c);

            //assert
            Assert.AreEqual(expectedRoot1, values.Root1);
            Assert.AreEqual(expectedRoot2, values.Root2);
        }

        [TestCase(1,2,2, double.NaN, double.NaN)]
        public void Solve_GivenCoefficients_Should_ReturnNoRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            //arrange
            SquareEquationSolver instance = GetTestInstance();

            //act
            EquationSolution values = instance.Solve(a, b, c);

            //assert
            Assert.AreEqual(expectedRoot1, values.Root1);
            Assert.AreEqual(expectedRoot2, values.Root2);
        }

        [Test]
        public void SolveAndSaveSolution_GivenResult_ShouldLog()
        {
            //arrange           
            string testPath = "test";
            SquareEquationSolver instance = GetTestInstanceWithLoggermock(out var loggerMock);

            //act
            instance.SolveAndSaveSolution(1, 1, 1, testPath);

            //assert
            loggerMock.Verify(it => it.Log(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}