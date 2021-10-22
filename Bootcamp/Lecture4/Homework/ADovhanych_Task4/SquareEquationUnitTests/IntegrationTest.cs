using System;
using System.IO;
using NUnit.Framework;
using TDDSquareEquation;

namespace SquareEquationUnitTests
{
    [TestFixture]
    class IntegrationTest
    {
        [Test]
        public void CheckFileForTheData()
        {
            Solver solver = new Solver();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            solver.SolveAndSave(4, 8, 4, filePath);
            string expected = "Root #1: -1";

            Assert.AreEqual(expected, File.ReadAllText("result.txt"));
        }
    }
}
