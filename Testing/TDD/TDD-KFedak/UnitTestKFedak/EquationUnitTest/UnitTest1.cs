using NUnit.Framework;

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
            QuadraticFunction quadraticFunction = new QuadraticFunction(a, b, c);
            var expectedRoot = quadraticFunction.Slove();

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
            QuadraticFunction quadraticFunction = new QuadraticFunction(a, b, c);
            var expectedRoot = quadraticFunction.Slove();

            //act
            var actualroot = quadraticFunction.DeltaBiggerThanZero(a ,b);

            //assert
            Assert.AreEqual(actualroot.X1, expectedRoot.X1);
            Assert.AreEqual(actualroot.X2, expectedRoot.X2);
        }

        [Test]
        [TestCase(1, 2, 5)]
        public void EquationHasNotSolution(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction(a, b, c);

            //act&&assert
            Assert.That(() => quadraticFunction.Slove(), Throws.TypeOf<NoSolution>());
        }

        [Test]
        [TestCase(1, 2, 5)]
        public void EquationHasNotSolutionMessage(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction(a, b, c);

            //act&&assert
            var ex = Assert.Throws<NoSolution>(() => quadraticFunction.Slove());
            Assert.That(ex.Message, Is.EqualTo("Determinate < 0.\n No solution"));
        }

        [Test]
        [TestCase(1, 2, 5)]
        public void EquationHasNotSolutionCatchException(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction(a, b, c);

            //act&&assert
            var ex = Assert.Throws<NoSolution>(() => quadraticFunction.Slove());
            Assert.That(ex.Message, Is.EqualTo("Determinate < 0.\n No solution"));
        }

        [Test]
        [TestCase (1,2,5)]
        public void CorrectValueOfDelta(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction(a, b, c);

            //act
            var actualDelta = quadraticFunction.CalculateDelta();
            var expectedDelta = System.Math.Pow(b, 2) - 4 * a * c;

            Assert.AreEqual(actualDelta, expectedDelta);
        }
    }
}