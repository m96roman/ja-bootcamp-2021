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
            //arrange
            //act
            string resultRoots = Solver.FindRoots(a, b, c);

            //assert
            Assert.AreEqual(expectedRoot, resultRoots);      
        }

        
        [TestCase(4, 4, 1, "<Root #1: -0.5;>")]
        public void CheckingSolvationWrittenToFile(double a, double b, double c, string expectedRoot)
        {
            //arrrange
            string fullPath = @"C:\Users\viktoriia.dedenok\Desktop\ja-bootcamp-2021\Testing\IntegrationTesting\Task2_Dedenok\EquationSolver2\EquationSolver2\bin\Debug\net5.0\ResultedRoots.txt";
           
            Mock<ISaveResultWrapper> wrapper = new();

            Solver solver = new Solver(wrapper.Object);

            //Solver.Wrapper = wrapper.Object;
            //Solver solve = new();

            //act
            solver.SolveAndSaveSolution(a, b, c, fullPath);

            //assert 
            wrapper.Verify(f => f.SaveResult(expectedRoot, fullPath), Times.Once);

        }
    }
}