using NUnit.Framework;
using square_equation;
using System;
using Moq;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class Tests
    {
        Mock<ISquereCalculator> _solverMock = new Mock<ISquereCalculator>();
        Mock<IResultSaver> _saverMock = new Mock<IResultSaver>();
        public string path = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Testing\Pylat Test 3\Lecture3\Text.txt";

        [TestCase(0, 6, 7)]
        public void Test1_(int a, int b, int c)
        {
            var x1 = 2;
            var x2 = 2;
            var expectedRsult = new List<double>() { x1, x2 };

            _solverMock.Setup(x => x.SolveSquereEquation(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>())).Returns(expectedRsult);

            _saverMock.Setup(x => x.SaveResult(It.Is<List<double>>(list => list == expectedRsult), It.IsAny<string>())).Returns(true);

            CalculationService service = new CalculationService(_solverMock.Object, _saverMock.Object);

            service.SolveAndSave(a, b, c, "path");

            Mock.VerifyAll(_solverMock, _saverMock);
        }

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

        //[TestCase(1, 16, 1)]
        //public void Test1_X1_IsEqual(int a, int b, int c)
        //{
        //    Equation.SquereEquation(a, b, c);
        //    Assert.AreEqual(-0.0627460668062279, Equation.SolveX1_When_D_MoreThan0(a, b, Equation.SolveD(a, b, c)), 0.000001);
        //}

        //[TestCase(1, 16, 1)]
        //public void Test2_DetIsNotNull(int a, int b, int c)
        //{
        //    Assert.NotNull(Equation.SolveD(a, b, c));
        //}

        //[TestCase(1, 0, 0)]
        //public void Test3_Det_0(int a, int b, int c)
        //{
        //    Assert.AreEqual(0, Equation.SolveD(a, b, c));
        //}

        //[TestCase(1, 0, 0)]
        //public void Test4_Det0_X1_IsEqual_X2(int a, int b, int c)
        //{
        //    Assert.AreEqual(0, Equation.SolveD(a, b, c));
        //    Assert.AreEqual(Equation.SolveX1_When_D_Is0(a, b, Equation.SolveD(a, b, c)), Equation.SolveX1_When_D_Is0(a, b, Equation.SolveD(a, b, c)));
        //}

        //[TestCase(0, 6, 7)]
        //public void Test5_DetLessThan_0(int a, int b, int c)
        //{
        //    var ex = Assert.Throws<Exception>(() => Equation.SolveD(a, b, c));
        //    Assert.That(ex.Message, Is.EqualTo("a == 0 or d < 0"));
        //}

        //[TestCase(0, 6, 7)]
        //public void Test6_a_IsEqual_0(int a, int b, int c)
        //{
        //    var ex = Assert.Throws<Exception>(() => Equation.SolveD(a, b, c));
        //    Assert.That(ex.Message, Is.EqualTo("a == 0 or d < 0"));
        //}
    }
}