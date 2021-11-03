using Moq;
using NUnit.Framework;
using Equation.Interfaces;
using Equation.Models;

namespace Equation.UnitTests
{
    [TestFixture]
    public class SquareEquationSolverTests
    {
        [TestCase(5, 3, 7, "<No solution>")]
        [TestCase(1, 12, 36, "<Root #1: -6>")]
        [TestCase(1, -8, 12, "<Root #1: 6; Root #2: 2>")]
        public void SaveResults_ShouldReturnTrueIfRootsWrittenGood(double a, double b, double c, string content)
        {
            //arrange
            SquareEquationSolver solve = new SquareEquationSolver();
            Mock<IFileWrapper> fileMock = new Mock<IFileWrapper>();
            solve.Wrapper = fileMock.Object;
            Coefficients coef = new Coefficients { A = a, B = b, C = c };

            //act
            solve.SolveAndSaveSolution(coef, "file");

            //assert
            fileMock.Verify(it => it.WriteDataIntofile("file", content), Times.Once);
        }
    }
}
