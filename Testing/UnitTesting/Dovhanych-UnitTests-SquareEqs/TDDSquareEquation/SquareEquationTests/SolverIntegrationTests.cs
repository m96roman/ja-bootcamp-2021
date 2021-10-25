using System;
using System.IO;
using NUnit.Framework;
using TDDSquareEquation;
using Moq;

namespace SquareEquationUnitTests
{
    [TestFixture]
    class SolverIntegrationTests
    {
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");

        [TestCase(-3, -3, "<Root #1: -3>")]
        [TestCase(-3.25, -4.75, "<Root #1: -3.25; Root #2: -4.75>")]
        [TestCase(null, null, "<No solution>")]
        public void CheckIfResultIsWrittenInFile(double? root1, double? root2, string result)
        {
            //Arrange
            Solver solver = new();
            Roots roots = new(root1, root2);
            Mock<IFileWrapper> mock = new();
            Solver.FileWrapper = mock.Object;

            //Act
            solver.SaveResult(roots, filePath);

            //Arrange
            mock.Verify(f => f.CheckIfExists(filePath), Times.Once);
            mock.Verify(f => f.WriteTextInFile(filePath, result), Times.Once);
        }

        [TestCase(4, 8, 4, "<Root #1: -1>")]
        [TestCase(8, 20, 4, "<Root #1: -1.125; Root #2: -1.375>")]
        [TestCase(40, 20, 4, "<No solution>")]
        public void CheckForCorrectResultWrittenInFile(double a, double b, double c, string result)
        {
            //Arrange
            Solver solver = new();
            Mock<IFileWrapper> mock = new();
            Solver.FileWrapper = mock.Object;

            //Act
            solver.SolveAndSave(a, b, c, filePath);

            //Assert
            mock.Verify(f => f.WriteTextInFile(filePath, result), Times.Once);
        }
    }
}
