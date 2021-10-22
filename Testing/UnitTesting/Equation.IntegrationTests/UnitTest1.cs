using NUnit.Framework;
using Moq;
using Equation.Models;
using Equation.Interfaces;
using Equation;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(null, null, "<No solution>")]
        [TestCase(-6, null, "<Root #1: -6>")]
        [TestCase(6, 2, "<Root #1: 6; Root #2: 2>")]
        public void ExistFileCorrectData(double? r1, double? r2, string content)
        {
            //arrange
            Mock<IFileWrapper> fileMock = new Mock<IFileWrapper>();
            SquareEquationSolver solve = new SquareEquationSolver();
            solve.Wrapper = fileMock.Object;
            Roots roots = new Roots { R1 = r1, R2 = r2 };

            //act
            solve.SaveResults(roots, Equation.Program.filePath);

            //assert
            fileMock.Verify(it => it.CheckFileExists(Equation.Program.filePath), Times.Once);
            fileMock.Verify(it => it.WriteDataIntofile(Equation.Program.filePath, content), Times.Once);
        }
    }
}