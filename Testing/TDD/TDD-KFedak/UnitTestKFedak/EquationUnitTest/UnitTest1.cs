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
        public void TheresNoSolution(double a, double b, double c)
        {
            //arrange
            QuadraticFunction quadraticFunction = new QuadraticFunction(a, b, c);

            //act&&assert
            Assert.That(() => quadraticFunction.Slove(), Throws.TypeOf<NoSolution>());
        }
    }
}