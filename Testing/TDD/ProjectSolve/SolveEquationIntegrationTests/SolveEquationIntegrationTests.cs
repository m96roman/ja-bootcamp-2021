using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SolveEquation;


namespace ProjectSolve.UnitTests
{
    [TestFixture]
    class SolveEquationIntegrationTests
    {
        [Test]
        public void Test_Check_file_should_return_correcr_value()
        {
            Equation equation = new Equation();
            equation.SolveAndSaveSolution(4, 11, 4, @"C:\Users\Yevhen.shyptur\Desktop\");
            string expectedResult = "< Root #1: -0.4312706956; Root #2: -2.3187293044>";

            Assert.IsTrue(File.Exists(@"C:\Users\Yevhen.shyptur\Desktop\Result.txt"));

            var actualText = File.ReadAllText(@"C:\Users\Yevhen.shyptur\Desktop\Result.txt");
            Assert.AreEqual(expectedResult, actualText);
        }
    }
}
