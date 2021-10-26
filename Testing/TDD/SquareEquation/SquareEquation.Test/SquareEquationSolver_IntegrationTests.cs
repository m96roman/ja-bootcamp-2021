using NUnit.Framework;
using Moq;
using System.IO;

namespace SquareEquation.Test
{
    [TestFixture]
    public class SquareEquationSolver_IntegrationTests
    {

        //loggerMock.Verify(it => it.Log(errorMsg, It.IsAny<MessageType>(), It.IsAny<string>()));

        private SquareEquationSolver GetTestInstanceWithLoggermock(out Mock<ILogger> loggerMock)
        {
            loggerMock = new Mock<ILogger>();
            return new SquareEquationSolver(loggerMock.Object);
        }


        [Test]
        public void LoggerSave_TryToSave_ShouldCreateFile()
        {
            //arrange
            string testString = "test";
            string testPath = "..\\..\\..\\test.txt";
            File.Delete(testPath);
            ILogger logger = new LogSaver();

            //act
            logger.Log(testString, testPath);

            //assert
            Assert.That(File.Exists(testPath), Is.True);
        }

        [Test]
        public void LoggerSave_GivenTestString_ShouldEqualToSavedString()
        {
            //arrange
            string testString = @"qwert!@#$%^&*()_+-/\1234";
            string testPath = "..\\..\\..\\test.txt";
            ILogger logger = new LogSaver();

            //act
            logger.Log(testString, testPath);
            string actual = File.ReadAllText(testPath);

            //assert
            Assert.That(actual, Is.EqualTo(testString));
        }

        [Test]
        public void SolveAndSaveSolution_GivenResult_ShouldLog()
        {
            //arrange           
            string testPath = "test";
            SquareEquationSolver instance = GetTestInstanceWithLoggermock(out var loggerMock);

            //act
            instance.SolveAndSaveSolution(1, 1, 1, testPath);

            //assert
            loggerMock.Verify(it => it.Log(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

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

        [Test]
        public void SaveResult_SavedData_MatchExpectedData()
        {
            //arrange
            SquareEquationSolver instance = new SquareEquationSolver(new LogSaver());
            double root1 = -0.3540;
            double root2 = 2.3540;
            EquationSolution testSolution = new EquationSolution(-0.3540, 2.3540);
            string testPath = "..\\..\\..\\test.txt";
            string expectedData = $"<Root #1: {root1}; Root #2: {root2}>";

            //act & arrange
            instance.SaveResult(testSolution, testPath);
            string actualData = File.ReadAllText(testPath);

            //assert
            Assert.That(actualData, Is.EqualTo(expectedData));
        }
    }
}