using System;
using NUnit.Framework;
using Moq;

namespace SquareEquation.Test
{
    [TestFixture]
    public class SquareEquationSolver_Test
    {

        private SquareEquation.SquareEquationSolver GetTestInstance(double a, double b, double c)
        {
            InputValues values = new InputValues(a, b, c);
            return new SquareEquation.SquareEquationSolver(values);
        }

        private SquareEquation.SquareEquationSolver GetTestInstanceWithLoggermock(double a, double b, double c, out Mock<ILogger> loggerMock)
        {
            InputValues values = new InputValues(a, b, c);
            loggerMock = new Mock<ILogger>();
            return new SquareEquation.SquareEquationSolver(values, loggerMock.Object);
        }


        [Test]
        public void CalculateRoots_Given_A_IsZero_ShouldthrowExeption()
        {
            //arrange
            SquareEquation.SquareEquationSolver instance = GetTestInstance(0, 1, 1);

            //act & assert
            Assert.Throws<ArgumentException>(() => instance.CalculateRoots(out double actualRoot1, out double actualRoot2));
        }

        [TestCase("\'A\' cannot be zero, otherwise it is a linear equation!")]
        public void CalculateRoots_Given_A_IsZero_ShouldLogErrorMessage(string errorMsg)
        {
            //arrange
            SquareEquation.SquareEquationSolver instance = GetTestInstanceWithLoggermock(0, 1, 1, out var loggerMock);
            
            //act
            Assert.Catch(() => instance.CalculateRoots(out double actualRoot1, out double actualRoot2));

            //assert
            loggerMock.Verify(it => it.Log(errorMsg, MessageType.Error));
        }

        [TestCase(1 ,3, 2, -1, -2)]
        [TestCase(1, -6, 0, 6, 0)]
        [TestCase(-6, 12, 5, -0.3540, 2.3540)]
        public void CalculateRoots_GivenCoefficients_ShouldReturnCorrectRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            //arrange
            SquareEquation.SquareEquationSolver instance = GetTestInstance(a, b, c);

            //act
            instance.CalculateRoots(out double actualRoot1, out double actualRoot2);

            //assert
            Assert.AreEqual(expectedRoot1, Math.Round(actualRoot1, 4));
            Assert.AreEqual(expectedRoot2, Math.Round(actualRoot2, 4));
        }

        [TestCase(1, 2, 1, -1, double.NaN)]
        public void CalculateRoots_GivenCoefficients_ShouldReturn_OnlyOneRoot(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            //arrange
            SquareEquation.SquareEquationSolver instance = GetTestInstance(a, b, c);

            //act
            instance.CalculateRoots(out double actualRoot1, out double actualRoot2);

            //assert
            Assert.AreEqual(expectedRoot1, actualRoot1);
            Assert.AreEqual(expectedRoot2, actualRoot2);
        }

        [TestCase(1,2,2, double.NaN, double.NaN)]
        public void CalculateRoots_GivenCoefficients_Should_ReturnNoRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            //arrange
            SquareEquation.SquareEquationSolver instance = GetTestInstance(a, b, c);

            //act
            instance.CalculateRoots(out double actualRoot1, out double actualRoot2);

            //assert
            Assert.AreEqual(expectedRoot1, actualRoot1);
            Assert.AreEqual(expectedRoot2, actualRoot2);
        }
    }
}