using Moq;
using NUnit.Framework;
using QuadraticSolver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticSolverTests.IntegrationTests
{
    [TestFixture]
    class IntegracyTestsing
    {

        [TestCase(2, 6, 3, "<A: 2; B: 6; C: 3; Root #1: -0.6339745962; Root #2: -2.3660254038>")]
        [TestCase(1, 2, 1, "<A: 1; B: 2; C: 1; Root #1: -1>")]
        [TestCase(0, 2, 1, "<NoSolution>")]
        [TestCase(1, 0, 3, "<TwoImaginaryRoots>")]
        public void GivenDataFromFile_ShouldPrintRoots(double a, double b, double c, string expected)
        {
            //Arrange
            QuadraticEquation quadraticEquation = new QuadraticEquation(a, b, c);

            //Act
            quadraticEquation.WriteAndSolve("text.txt");

            //Arrange
            Assert.IsTrue(File.Exists("text.txt"));

            var text = File.ReadAllText("text.txt");

            Assert.AreEqual(expected, text);
        }

        [TestCase("\\//ddd123")]
        public void SolutionWrongPathFormat_ThrowIOException(string wrongPath)
        {
            //Arrange
            QuadraticEquation quadraticEquation = new QuadraticEquation(1, 2, 3);

            //Act+Arrange
            Assert.That(() => quadraticEquation.WriteAndSolve(wrongPath),
                  Throws.InstanceOf<IOException>());
        }
    }
}
