using NUnit.Framework;
using System.IO;

namespace SquareEquation.UnitTests
{
    public class ResultSaverServiceTest
    {
        public string path = @"C:\Users\Admin\Desktop\JustAnswer\ja-bootcamp-2021\Testing\Pylat test 4\Lecture4\File.txt";

        [TestCase(1, 16, 1)]
        public void SolveAndSave_WhenTwoRoots_ShouldWriteFileContentCorrectly(int a, int b, int c)
        {
            //Arrange
            SquareEquationService squere = new SquareEquationService();
            ResultSaverService result = new ResultSaverService();
            CalculationService calculation = new CalculationService(squere, result);

            var exprctedRes = "< Root #1: -0,06274606680622785; Root #2: -15,937253933193773>";

            //Act
            calculation.SolveAndSave(a, b, c, path);

            //Assert
            Assert.That(path, Does.Exist);
            Assert.AreEqual(exprctedRes, File.ReadAllText(path));
        }

        [TestCase(1, 2, 1)]
        public void SolveAndSave_WhenOneRoot_ShouldWriteFileContentCorrectly(int a, int b, int c)
        {
            //Arrange
            SquareEquationService squere = new SquareEquationService();
            ResultSaverService result = new ResultSaverService();
            CalculationService calculation = new CalculationService(squere, result);

            var exprctedRes = "< Root #1: -1 >";

            //Act
            calculation.SolveAndSave(a, b, c, path);

            //Assert
            Assert.That(path, Does.Exist);
            Assert.AreEqual(exprctedRes, File.ReadAllText(path));
        }

        [TestCase(0, 16, 1)]
        public void SolveAndSave_WhenNoRoots_ShouldWriteFileContentCorrectly(int a, int b, int c)
        {
            //Arrange
            SquareEquationService squere = new SquareEquationService();
            ResultSaverService result = new ResultSaverService();
            CalculationService calculation = new CalculationService(squere, result);

            var exprctedRes = "<No solution>";

            //Act
            calculation.SolveAndSave(a, b, c, path);

            //Assert
            Assert.That(path, Does.Exist);
            Assert.AreEqual(exprctedRes, File.ReadAllText(path));
        }
    }
}