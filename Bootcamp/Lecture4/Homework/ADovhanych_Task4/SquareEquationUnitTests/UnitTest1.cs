using NUnit.Framework;
using TDDSquareEquation;

namespace SquareEquationUnitTests
{
    public class Tests
    {
        [Test]
        [TestCase(7, 5, 3)]
        public void NoSolutionForTheEquation(double a, double b, double c)
        {
            SquareEquation squareEquation = new SquareEquation();

            Assert.That(() => squareEquation.SquareEquationSolution(a, b, c), Throws.TypeOf<NoRootsException>());
        }

        [Test]
        [TestCase(1, 5, 3)]
        public void CheckForTwoSolutionsInSquareEq(double a, double b, double c)
        {            
            SquareEquation equation = new SquareEquation();
            Roots roots = equation.SquareEquationTwoRoots(a, b, c);
            
            var expectedOne = (-1.6339745962155614);
            var expectedTwo = (-3.3660254037844384);

            Assert.AreEqual(expectedOne, roots.Root1);
            Assert.AreEqual(expectedTwo, roots.Root2);
        }

        [Test]
        [TestCase(4, 8, 4)]
        public void CheckForOneSolutionInSquareEq(double a, double b, double c)
        {
            SquareEquation equation = new SquareEquation();
            Roots roots = equation.SquaqreEquationOneRoot(a, b, c);

            var expectedRoot = (-1);

            Assert.AreEqual(expectedRoot, roots.Root1);
        }     
        
        [Test]
        [TestCase(5, 14, 6)]
        public void CheckForSolutions(double a, double b, double c)
        {
            SquareEquation equation = new SquareEquation();
            Roots roots = equation.SquareEquationSolution(a, b, c);

            var expectedOne = (-1.1550510257216822);
            var expectedTwo = (-1.6449489742783179);

            Assert.AreEqual(expectedOne, roots.Root1);
            Assert.AreEqual(expectedTwo, roots.Root2);
        }
    }
}