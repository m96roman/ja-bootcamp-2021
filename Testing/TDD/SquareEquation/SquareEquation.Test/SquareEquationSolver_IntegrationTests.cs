using NUnit.Framework;
using Moq;
using System.IO;

namespace SquareEquation.Test
{
    [TestFixture]
    public class SquareEquationSolver_IntegrationTests
    {
        [Test]
        public void SolveAndSaveSolution_GivenResults_ShouldMatchExpectedFormat_ForTwoRoots()
        {
            //arrange
            double root1 = -1;
            double root2 = -2;
            string expectedResult = $"<Root #1: {root1}; Root #2: {root2}>";
            string testPath = "..\\..\\..\\test.txt";
            SquareEquationSolver instance = new SquareEquationSolver(new LogSaver());

            //act
            instance.SolveAndSaveSolution(1, 3, 2, testPath);

            //assert
            string actualResult = File.ReadAllText(testPath);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SolveAndSaveSolution_GivenResults_ShouldMatchExpectedFormat_ForOneRoot()
        {
            //arrange
            double root1 = -1;
            string expectedResult = $"<Root #1: {root1}>";
            string testPath = "..\\..\\..\\test.txt";
            SquareEquationSolver instance = new SquareEquationSolver(new LogSaver());

            //act
            instance.SolveAndSaveSolution(1, 2, 1, testPath);

            //assert
            string actualResult = File.ReadAllText(testPath);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SolveAndSaveSolution_GivenResults_ShouldMatchExpectedFormat_ForNoRoots()
        {
            //arrange
            string expectedResult = "<No solution>";
            string testPath = "..\\..\\..\\test.txt";
            SquareEquationSolver instance = new SquareEquationSolver(new LogSaver());

            //act
            instance.SolveAndSaveSolution(1, 1, 1, testPath);

            //assert
            string actualResult = File.ReadAllText(testPath);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SaveResult_ShouldCreateNewFile()
        {
            //arrange
            SquareEquationSolver instance = new SquareEquationSolver(new LogSaver());
            EquationSolution testSolution = new EquationSolution(1, 1);
            string testPath = "..\\..\\..\\test.txt";
            File.Delete(testPath);         

            //act
            instance.SaveResult(testSolution,testPath);

            //assert
            Assert.That(File.Exists(testPath), Is.True);
        }
    }
}