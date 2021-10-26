using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace SquareEquation.UnitTests
{
    public class ResultSaverServiceTest
    {
        public string path = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Testing\Pylat test 4\Lecture4";

        [TestCase(1, 16, 1)]
        public void Test2_(int a, int b, int c)
        {
            SquareEquationService squere = new SquareEquationService();
            ResultSaverService result = new ResultSaverService();
            CalculationService calculation = new CalculationService(squere, result);
            var list = squere.Solve(a, b, c);
            var exprctedRes = "< Root #1: -0.0627460668062279; Root #2: -15.9372539331938>";

            calculation.SolveAndSave(a, b, c, path);

            Assert.AreEqual(exprctedRes, File.ReadAllText(path));

        }
    }
}