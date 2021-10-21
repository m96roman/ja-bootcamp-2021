using Moq;
using NUnit.Framework;
using QuadraticSolver;
using System;

namespace QuadraticSolver.Tests
{
    [TestFixture]
    public class QuadraticSolverTests
    {
        private Solution GetSolution(double a, double b, double c)
        {
            QuadraticEquation quadraticEquaion = new QuadraticEquation(a, b, c);

            return quadraticEquaion.GetSolution();
        }

        #region GetSolution() tests

        [Test]
        public void Test_ThrowsArgumentException_When_A_0()
        {
            Assert.That(() => GetSolution(0, 3, 4),
                Throws.TypeOf<NoRootsException>());
        }

        [TestCase(9, -6, 60)]
        [TestCase(0.1, 0.0001, 60)]
        [TestCase(9, -1, 60)]
        [TestCase(0.1, 2, 60)]
        public void Test_ThrowsRootsException_When_Discriminant_less_0(double a, double b, double c)
        {
            Assert.That(() => GetSolution(a, b, c),
               Throws.TypeOf<NoRootsException>());
        }

        [TestCase(1, 2, 3, -8, 0.000001)]
        [TestCase(3, 4, 1, 4, 0.000001)]
        [TestCase(2.05, 3, 1, 0.8, 0.000001)]
        [TestCase(5.0001, 2.333, 4, -74.558711, 0.000001)]
        [TestCase(-0.3, 0.2, 0.5, 0.64, 0.000001)]
        public void Test_Disriminant(double a, double b, double c, double expected, double delta)
        {
            QuadraticEquation equaion = new(a, b, c);

            Assert.AreEqual(expected, equaion.GetDiscriminant(a, b, c), delta);
        }

        [TestCase(4, 4, 1, -0.5, 0.000001)]
        [TestCase(0.4, 0.4, 0.1, -0.5, 0.000001)]
        public void Test_For_OneSolution(double a, double b, double c, double expectedRoot, double delta)
        {
            var sol = GetSolution(a, b, c);

            Assert.That(sol.SolutionType == TypesOfSolution.OneRoot);
            Assert.AreEqual(sol.Root1, expectedRoot, delta);
        }

        [TestCase(2, 6.7, -4, 0.517174, -3.86717, 0.00001)]
        [TestCase(8.00003, 6.7, -4, 0.403047, -1.24054, 0.00001)]
        public void Test_For_TwoRealSolutions(double a, double b, double c, double expectedRoot1, double expectedRoot2, double delta)
        {
            var sol = GetSolution(a, b, c);

            Assert.That(sol.SolutionType == TypesOfSolution.TwoRealRoots);

            Assert.AreEqual(sol.Root1, expectedRoot1, delta);
            Assert.AreEqual(sol.Root2, expectedRoot2, delta);
        }

        #endregion

        #region SolveAndSaveSolution() tests

        [TestCase(2, 4, 1, "<A: 2; B: 4; C: 1; Root #1: -0.2928932188; Root #2: -1.7071067812>")]
        [TestCase(1, 2, 1, "<A: 1; B: 2; C: 1; Root #1: -1>")]
        [TestCase(0, 2, 1, "<NoSolution>")]
        [TestCase(2, 1, 4, "<TwoImaginaryRoots>")]
        public void SolveAndSaveSolution(double a, double b, double c, string expectedFormat)
        {
            //Arrange
            QuadraticEquation quadraticEquaion = new QuadraticEquation(a, b, c);

            Mock<ISolutionWriter> solutionSaverMock = new Mock<ISolutionWriter>();
            solutionSaverMock.Setup(sS => sS.IsExists("file"))
                .Returns(false);

            quadraticEquaion.Writer = solutionSaverMock.Object;

            //Act
            quadraticEquaion.WriteAndSolve("file");

            //Assert
            solutionSaverMock.Verify(sS => sS.Write(expectedFormat, "file", false),
                Times.Once);
        }

        #endregion
    }
}