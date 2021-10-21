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
            solver.SolveAndSave(5, 2, 1);
            string expected = "<No solution>";
            string asd = File.ReadAllText("Solution.txt");

            Assert.AreEqual(expected, File.ReadAllText("Solution.txt"));

        }
    }
}
