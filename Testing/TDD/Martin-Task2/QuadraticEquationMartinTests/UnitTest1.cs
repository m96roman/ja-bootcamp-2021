using NUnit.Framework;
using QuadraticEquationMartin;
using System;

namespace QuadraticEquationMartinTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("0", "0", "0")]
        [TestCase("000", "65", "56")]
        public void Parse_GivenFirstNull_ShouldThrowArgumentException(string a, string b, string c)
        {
            var inputDate = new InputDate();
            Assert.That(() => inputDate.ValiDateInputData(a, b, c), Throws.ArgumentException);
        }

        [TestCase("a", "b", "c")]
        [TestCase("asd", "0", "reter")]
        [TestCase("#@2", "a", "43")]
        public void Parse_GivenInvalidInput_ShouldThrowArgumentException(string a, string b, string c)
        {
            var inputDate = new InputDate();
            Assert.That(() => inputDate.ValiDateInputData(a, b, c), Throws.ArgumentException);
        }

        [TestCase("1", "2", "5")]
        [TestCase("-321", "2", "21354")]
        [TestCase("1", "-213213.32", "3223.342")]
        public void Parse_GivenCorrectDate_ShouldThrowArgumentException(string a, string b, string c)
        {
            var inputDate = new InputDate();
            Assert.DoesNotThrow(() => inputDate.ValiDateInputData(a, b, c));
        }

        [TestCase("1","-26","120",20,6)]
        [TestCase("1", "372", "3620", -10, -362)]
        [TestCase("-1", "4", "1", -0.2360679774997898, 4.23606797749979)]
        public void Parse_GivenCorrectArgument_ShouldReturnCorrectRoots(string a, string b, string c,double r1,double r2)
        {
            var inputDate = new InputDate(a,b,c);
            inputDate.SolveTheEquation();
            Assert.AreEqual(Math.Round(inputDate.R1, 10), Math.Round(r1, 10));
            Assert.AreEqual(Math.Round(inputDate.R2, 10), Math.Round(r2, 10));
        }

        [TestCase("1", "-1", "1")]
        [TestCase("2", "3", "12")]
        public void Parse_GivenArgument_ShouldThrowNoRootsException(string a, string b, string c)
        {
            var inputDate = new InputDate(a, b, c);
            inputDate.FindD(inputDate.A,inputDate.B,inputDate.C);
            Assert.That(() => inputDate.FindRoots(inputDate.D), Throws.TypeOf<NoRootsException>());
        }

    }
}