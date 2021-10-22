using NUnit.Framework;
using Equation;
using Moq;

namespace EquationTest

{
    [TestFixture]
    public class QuadraticEquationTest
    {

        [TestCase(1, 6, 9,-3)]
        public void EquationHasOneResult(double a, double b, double c,double result)
        {
            //arrange
            QuadraticFunction quadraticFunction = new();

            //act
            var expectedRoot = quadraticFunction.Slove(a, b, c);
            var actualroot = result;

            //assert
            Assert.AreEqual(actualroot, expectedRoot.X1);
        }

        [TestCase(1, -4, -5,-1,5)]
        public void EquationHasTwoResults(double a, double b, double c, double x1,double x2)
        {
            //arrange
            QuadraticFunction quadraticFunction = new();

            //act
            var expectedRoot = quadraticFunction.Slove(a, b, c);

            //assert
            Assert.AreEqual(x1, expectedRoot.X1);
            Assert.AreEqual(x2, expectedRoot.X2);
        }

        [TestCase(1, 2, 5)]
        public void EquationHasNotSolutionMessage(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new();

            //act&&assert
            var ex = Assert.Throws<NoSolution>(() => quadraticFunction.Slove(a, b, c));
            Assert.That(ex.Message, Is.EqualTo("No solution"));
        }

        [TestCase(1, -4, -5, "Root #1: -1; Root #2: 5")]
        [TestCase(1, 6, 9, "Root #1: -3")]
        [TestCase(1, 2, 5, "No solution")]
        public void ResultWriteInFile(double a, double b, double c, string result)
        {
            //arrange
            QuadraticFunction quadraticFunction = new();
            Mock<IFileWrapper> fileMock = new();
            quadraticFunction.FileWrapper = fileMock.Object;

            //act
            quadraticFunction.SolveAndSaveSolution(a, b, c, "file");

            //assert
            fileMock.Verify(it => it.WriteInFile("file", result), Times.Once);
        }
    }
}