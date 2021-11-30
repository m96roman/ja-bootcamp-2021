using NUnit.Framework;
using SquareEquationSolver;
using System.IO;

namespace EquationSolver2.IntegrationTests
{
    [TestFixture]
    public class SolverTests
    {
        [TestCase(4, 9, 0, "<Root #1: 0; Root #2: -2.25;>")]
        public void CheckingFileIsCreatedAndWithCorrectData(double a, double b, double c, string expectedRoot)
        {
            //arrange
            Solver consoleSaver = new Solver(new ConsoleSaver());

            Solver solve = new Solver(new SaveResultWrapper());


            string directoryPath = Directory.GetCurrentDirectory();
            string fileName = @"\ResultedRoots.txt";
            string fullPath = directoryPath + fileName;

            //act

            solve.SolveAndSaveSolution(a, b, c, fullPath);
            string resultedText = File.ReadAllText(fullPath);

            //assert
            Assert.IsTrue(File.Exists(fullPath));
            Assert.AreEqual(expectedRoot, resultedText);
        }
    }
}