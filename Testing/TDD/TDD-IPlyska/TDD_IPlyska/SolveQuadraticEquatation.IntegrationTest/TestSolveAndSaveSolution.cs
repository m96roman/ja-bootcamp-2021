using NUnit.Framework;
using SolveQuadraticEquatation;
using System.IO;

namespace IntegrationTest_SolveQuadraticEquatation
{
    public class TestSolveAndSaveSolution
    {
        readonly SquareEquationSolver equation = new SquareEquationSolver();

        [TestCase(2, 4, 2, "<Root #1: -1>")]
        [TestCase(-5.6, 2.22, 1.24, "<Root #1: -9,7965730599; Root #2: 22,2285730599>")]
        [TestCase(0, 0, 3, "<No solution>")]
        public void SolveAndSaveSolution_With_Inegration_Test_File_Should_Exist(double a, double b, double c, string context)
        {
            //act
            equation.SolveAndSaveSolution(a, b, c, equation.FilePath);
            var result = File.ReadAllText(equation.FilePath);

            //assert
            Assert.That(equation.FilePath, Does.Exist);
            Assert.That(result, Is.EqualTo(context));
        }
    }
}