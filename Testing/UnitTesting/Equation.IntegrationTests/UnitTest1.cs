using NUnit.Framework;
using Moq;
using Equation.Models;
using Equation.Interfaces;
using Equation;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(null, null, "<No solution>")]
        [TestCase(-6, null, "<Root #1: -6>")]
        [TestCase(6, 2, "<Root #1: 6; Root #2: 2>")]
        public void ExistFileCorrectData(double? r1, double? r2, string expectedContent)
        {
            //arrange
            SquareEquationSolver solve = new SquareEquationSolver();
            Roots roots = new Roots { R1 = r1, R2 = r2 };

            //act
            solve.SaveResults(roots, Equation.Program.filePath);

            //assert
            FileAssert.Exists(Equation.Program.filePath);
            Assert.That(File.ReadAllText(Equation.Program.filePath), Is.SameAs(expectedContent));
        }
    }
}