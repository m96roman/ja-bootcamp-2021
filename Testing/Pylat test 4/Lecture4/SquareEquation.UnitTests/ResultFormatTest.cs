using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace SquareEquation.UnitTests
{
    public class ResultFormatTest
    {
        public string path = @"C:\Users\Admin\Desktop\JustAnswer\ja-bootcamp-2021\Testing\Pylat test 4\Lecture4\File.txt";

        [TestCase(1, 16, 1)]
        public void Solve_WhenTwoRoots_ResultIsCorrect(int a, int b, int c)
        {
            //Arrange
            SquareEquationService squere = new SquareEquationService();

            var exprctedRoot1 = -0.06274606680622785;
            var exprctedRoot2 = -15.937253933193773;

            //Act
            var res = squere.Solve(a, b, c);

            //Assert
            Assert.AreEqual(exprctedRoot1, res[0]);
            Assert.AreEqual(exprctedRoot2, res[1]);
        }

        [TestCase(1, 2, 1)]
        public void Solve_WhenOneRoot_ResultIsCorrect(int a, int b, int c)
        {
            //Arrange
            SquareEquationService squere = new SquareEquationService();

            var exprctedRoot1 = -1;

            //Act
            var res = squere.Solve(a, b, c);

            //Assert
            Assert.AreEqual(exprctedRoot1, res[0]);
        }

        [TestCase(0, 16, 1)]
        public void Solve_WhenNoRoots_ResultIsCorrect(int a, int b, int c)
        {
            //Arrange
            SquareEquationService squere = new SquareEquationService();

            var exprctedRoot1 = new List<double>();

            //Act
            var res = squere.Solve(a, b, c);

            //Assert
            Assert.AreEqual(exprctedRoot1, res);
        }
    }
}