using NUnit.Framework;
using square_equation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lecture3
{
    [TestFixture]
    class ResultSaverTest
    {
        public string path = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Testing\Pylat test 4\Lecture4\Text.txt";
        [TestCase(1, 16, 1)]
        public void Test2_(int a, int b, int c)
        {
            SquereEquetionSolver squere = new SquereEquetionSolver();
            ResultSaver result = new ResultSaver();
            CalculationService calculation = new CalculationService(squere, result);
            var list = squere.SolveSquereEquation(a, b, c);
            var exprctedRes = "< Root #1: -0.0627460668062279; Root #2: -15.9372539331938>";

            calculation.SolveAndSave(a, b, c, path);

            Assert.AreEqual(exprctedRes, File.ReadAllText(path));

        }
    }
}
