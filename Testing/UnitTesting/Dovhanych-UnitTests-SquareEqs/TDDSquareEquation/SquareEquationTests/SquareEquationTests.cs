using NUnit.Framework;
using TDDSquareEquation;

namespace SquareEquationUnitTests
{
    public class SquareEquationTests
    {
        [TestCase(7, 5, 3)]
        [TestCase(8, 3, 2)]
        [TestCase(20, 10, 5)]
        public void NoSolutionForTheEquation(double a, double b, double c)
        {
            //Arrange
            SquareEquation squareEquation = new();

            //Assert
            Assert.That(() => squareEquation.SquareEquationSolution(a, b, c), Throws.TypeOf<NoRootsException>());
        }

        [TestCase(1, 5, 3, -1.6339745962155614, -3.3660254037844384)]
        [TestCase(5, 12, 6, -0.9550510257216821, -1.444948974278318)]
        [TestCase(8, 20, 4, -1.125, -1.375)]
        public void CheckForTwoSolutionsInSquareEq(double a, double b, double c, double expectedOne, double expectedTwo)
        {
            //Arrange
            SquareEquation equation = new SquareEquation();

            //Act
            Roots roots = equation.SquareEquationTwoRoots(a, b, c);

            //Assert
            Assert.AreEqual(expectedOne, roots.Root1);
            Assert.AreEqual(expectedTwo, roots.Root2);
        }

        [TestCase(4, 8, 4, -1)]
        [TestCase(1, 6, 9, -3)]
        [TestCase(1, 10, 25, -5)]
        public void CheckForOneSolutionInSquareEq(double a, double b, double c, double expectedRoot)
        {
            //Arrange
            SquareEquation equation = new SquareEquation();

            //Act
            Roots roots = equation.SquareEquationOneRoot(a, b, c);

            //Assert
            Assert.AreEqual(expectedRoot, roots.Root1);
        }

        [TestCase(5, 14, 6, -1.1550510257216822, -1.6449489742783179)]
        [TestCase(2, 16, 9, -3.25, -4.75)]
        public void CheckForSolutions(double a, double b, double c, double expectedOne, double expectedTwo)
        {
            //Arrange
            SquareEquation equation = new SquareEquation();

            //Act
            Roots roots = equation.SquareEquationSolution(a, b, c);

            //Assert
            Assert.AreEqual(expectedOne, roots.Root1);
            Assert.AreEqual(expectedTwo, roots.Root2);
        }
    }
}