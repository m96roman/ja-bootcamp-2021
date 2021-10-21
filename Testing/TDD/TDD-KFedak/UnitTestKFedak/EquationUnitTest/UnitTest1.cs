using NUnit.Framework;
using Equation;
using Moq;

namespace EquationUnitTest

{
    [TestFixture]
    public class QuadraticEquationTest
    {

        [Test]
        [TestCase(1, 6, 9)]
        public void EquationHasOneResult(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction();
            var expectedRoot = quadraticFunction.Slove(a, b, c);

            //act
            var actualroot = quadraticFunction.DeltaEqualZero(a, b);

            //assert
            Assert.AreEqual(actualroot.X1, expectedRoot.X1);
        }

        [Test]
        [TestCase(1, -4, -5)]
        public void EquationHasTwoResults(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction();
            var expectedRoot = quadraticFunction.Slove(a, b, c);

            //act
            var actualroot = quadraticFunction.DeltaBiggerThanZero(a, b, c);

            //assert
            Assert.AreEqual(actualroot.X1, expectedRoot.X1);
            Assert.AreEqual(actualroot.X2, expectedRoot.X2);
        }

        [Test]
        [TestCase(1, 2, 5)]
        public void EquationHasNotSolution(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction();

            //act&&assert
            Assert.That(() => quadraticFunction.Slove(a, b, c), Throws.TypeOf<NoSolution>());
        }

        [Test]
        [TestCase(1, 2, 5)]
        public void EquationHasNotSolutionMessage(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction();

            //act&&assert
            var ex = Assert.Throws<NoSolution>(() => quadraticFunction.Slove(a, b, c));
            Assert.That(ex.Message, Is.EqualTo("No solution"));
        }

        [Test]
        [TestCase(1, 2, 5)]
        public void CorrectValueOfDelta(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction();

            //act
            var actualDelta = quadraticFunction.CalculateDelta(a, b, c);
            var expectedDelta = System.Math.Pow(b, 2) - 4 * a * c;

            Assert.AreEqual(actualDelta, expectedDelta);
        }

        [Test]
        public void CorrectFormatRootsInFile()
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction();

            //act
            //  var actualDelta = quadraticFunction.CalculateDelta(a, b, c);
            //   var expectedDelta = System.Math.Pow(b, 2) - 4 * a * c;

            // Assert.AreEqual(actualDelta, expectedDelta);
        }

        [Test]
        [TestCase(1, -4, -5, "Root #1: -1; Root #2: 5")]
        [TestCase(1, 6, 9, "Root #1: -3")]
        [TestCase(1, 2, 5, "No solution")]
        public void ResultWriteInFile(double a, double b, double c, string result)
        {
            //arrange
            QuadraticFunction quadraticFunction = new();
            Mock<IFileWrapper> fileStub = new();
            fileStub.Setup(it => it.CheckFileExists("file")).Returns(true);
            quadraticFunction.FileWrapper = fileStub.Object;

            //act
            quadraticFunction.SolveAndSaveSolution(a, b, c, "file");

            //assert
            fileStub.Verify(it => it.WriteInFile("file", result), Times.Once);
        }
    }
}