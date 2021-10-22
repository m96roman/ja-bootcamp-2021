using System;
using System.IO;
using NUnit.Framework;
using TDDSquareEquation;
using Moq;

namespace SquareEquationUnitTests
{
    [TestFixture]
    class IntegrationTest
    {
        [Test]
        [TestCase(4, 8, 4)]
        public void CheckFileForTheData(double a, double b, double c)
        {
            Solver solver = new Solver();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            solver.SolveAndSave(a, b, c, filePath);
            string expected = "Root #1: -1";

            Assert.AreEqual(expected, File.ReadAllText("result.txt"));
        }

        [Test]
        public void CheckIfFileExistsTest()
        {            
            Mock<IFileWrapper> mock = new();
            Solver.FileWrapper = mock.Object;
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            Solver solver = new();
            solver.SolveAndSave(4, 8, 4, filePath);

            mock.Verify(f => f.CheckIfExists(filePath), Times.Once);
        }
    }
}
