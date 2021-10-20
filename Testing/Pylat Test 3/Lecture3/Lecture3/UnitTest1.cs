using NUnit.Framework;
using square_equation;
using System;

namespace Tests
{
    public class Tests
    {
        readonly Equation equation = new Equation();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 16, 1)]
        public void Test1_X1_IsEqual(int a, int b, int c)
        {
            equation.SquereEquation(a, b, c);
            Assert.AreEqual(-0.0627460668062279, equation.SolveX1When_D_MoreThan0(a, b, equation.SolveD(a, b, c)), 0.000001);
        }

        [TestCase(1, 16, 1)]
        public void Test2_DetIsNotNull(int a, int b, int c)
        {
            Assert.NotNull(equation.SolveD(a, b, c));
        }

        [TestCase(1, 0, 0)]
        public void Test3_Det_0(int a, int b, int c)
        {
            Assert.AreEqual(0, equation.SolveD(a, b, c));
        }

        [TestCase(1, 0, 0)]
        public void Test4_Det0_X1_IsEqual_X2(int a, int b, int c)
        {
            Assert.AreEqual(0, equation.SolveD(a, b, c));
            Assert.AreEqual(equation.SolveX1_When_D_Is0(a, b, equation.SolveD(a, b, c)), equation.SolveX2_When_D_Is0(a, b, equation.SolveD(a, b, c)));
        }

        [TestCase(0, 6, 7)]
        public void Test5_DetLessThan_0(int a, int b, int c)
        {
            var ex = Assert.Throws<Exception>(() => equation.SolveD(a, b, c));
            Assert.That(ex.Message, Is.EqualTo("a == 0 or d < 0"));
        }

        [TestCase(0, 6, 7)]
        public void Test6_a_IsEqual_0(int a, int b, int c)
        {
            var ex = Assert.Throws<Exception>(() => equation.SolveD(a, b, c));
            Assert.That(ex.Message, Is.EqualTo("a == 0 or d < 0"));
        }
    }
}