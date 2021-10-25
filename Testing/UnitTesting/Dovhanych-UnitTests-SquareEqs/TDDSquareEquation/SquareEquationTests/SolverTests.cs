using System;
using System.IO;
using NUnit.Framework;
using TDDSquareEquation;
using Moq;

namespace SquareEquationUnitTests
{
    [TestFixture]
    class SolverTests
    {
        [TestCase(4, 8, 4, "<Root #1: -1>", "some path")]
        [TestCase(8, 20, 4, "<Root #1: -1.125; Root #2: -1.375>", "some path two")]
        [TestCase(40, 20, 4, "<No solution>", "some path three")]
        public void CheckForCorrectResultWrittenInFile(double a, double b, double c, string result, string path)
        {
            //Arrange
            Solver solver = new();
            Mock<IFileWrapper> mock = new();
            Solver.FileWrapper = mock.Object;

            //Act
            solver.SolveAndSave(a, b, c, path);

            //Assert
            mock.Verify(f => f.CheckIfExists(path), Times.Once);
            mock.Verify(f => f.WriteTextInFile(path, result), Times.Once);
        }
    }
}
