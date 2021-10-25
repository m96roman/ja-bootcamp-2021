using System;
using System.IO;
using NUnit.Framework;
using TDDSquareEquation;

namespace TDDSquareEquation.IntegrationTests
{
    [TestFixture]
    class SolverIntegrationTests
    {
        [TestCase(1, 6, 9, "<Root #1: -3>")]
        [TestCase(2, 16, 9, "<Root #1: -3.25; Root #2: -4.75>")]
        [TestCase(29, 21, 13, "<No solution>")]
        public void TestMethodToSolveAndWriteInTex(double a, double b, double c, string result)
        {
            //Arrange
            Solver solver = new();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            //Act

            solver.SolveAndSave(a, b, c, filePath);

            //Assert
            Assert.That(File.Exists(filePath));
            Assert.AreEqual(result, File.ReadAllText(filePath));
        }
    }
}
