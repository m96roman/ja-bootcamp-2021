using Moq;
using NUnit.Framework;
using SquareEquationSolver;
using System.IO;

namespace EquationSolver2.UnitTests
{
    [TestFixture]
    public class SolverTests
    {     
        [TestCase(4, 9, 0, "<Root #1: 0; Root #2: -2.25;>")]
        [TestCase(4, 4, 1, "<Root #1: -0.5;>")]
        [TestCase(7, 11, 6, "<No solution>")]
        public void CheckingSolverResutCorrectFormat(double a, double b, double c, string expectedRoot)
        {       
            string resultRoots = Solver.FindRoots(a, b, c);

            Assert.AreEqual(expectedRoot, resultRoots);      
        }

        
        [TestCase(4, 4, 1, "<Root #1: -0.5;>")]
        public void CheckingSolvationWrittenToFile(double a, double b, double c, string expectedRoot)
        {
            string directoryPath = Directory.GetCurrentDirectory();

            string fileName = @"\ResultedRoots.txt";

            string fullPath = directoryPath + fileName;
           
            Mock<ISaveResultWrapper> wrapper = new();
              
            Solver.Wrapper = wrapper.Object;
            Solver solve = new();
           
            solve.SolveAndSaveSolution(a, b, c, fullPath);
          
            wrapper.Verify(f => f.SaveResult(expectedRoot, fullPath), Times.Once);

        }
    }
}