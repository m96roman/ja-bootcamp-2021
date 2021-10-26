using NUnit.Framework;
using SquareEquationSolver;
using System.IO;

namespace EquationSolver2.IntegrationTests
{
    [TestFixture]
    public class SolverTests
    {
        [TestCase (4, 9, 0, "<Root #1: 0; Root #2: -2.25;>")]
        public void CheckingFileIsCreatedAndWithCorrectData(double a, double b, double c, string expectedRoot)
        {
           Solver solve = new();
          
           string directoryPath = Directory.GetCurrentDirectory();
           string fileName = @"\ResultedRoots.txt";
           string fullPath = directoryPath + fileName;

           solve.SolveAndSaveSolution(a, b, c, fullPath);

           string resultedText = File.ReadAllText(fullPath);

           Assert.IsTrue(File.Exists(fullPath));
           Assert.AreEqual(expectedRoot, resultedText);
        }
    }
}