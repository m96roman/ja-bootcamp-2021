using NUnit.Framework;
using QuadraticEquationMartin;
using System;
using Moq;
using System.IO;
using System.Linq;
using QuadraticEquationMartin1;

namespace QuadraticEquationMartinTests
{
    [TestFixture]
    public class InputDateUnitTests
    {
        private readonly InputDate Date = new InputDate();

        [TestCase("", " ", "")]
        [TestCase(null, "0", null)]
        [TestCase("0", "2", "1")]
        [TestCase("asd", "0", "reter")]
        [TestCase("#@2", "a", "43")]
        public void ValidateInputData_InvalidInput_ShouldThrowArgumentException(string a, string b, string c)
        {
            Assert.That(() => Date.ValidateInputData(a, b, c), Throws.ArgumentException);
        }

        [TestCase("1", "2", "0", 1, 2, 0)]
        [TestCase("-321", "2", "21354", -321, 2, 21354)]
        [TestCase("1", "-213213.32", "3223.342", 1, -213213.32, 3223.342)]
        public void ValidateInputData_Numbers_ShouldGetCorrectData(string a, string b, string c, double _a, double _b, double _c)
        {
            Date.ValidateInputData(a, b, c);

            Assert.AreEqual(Date.A, _a);
            Assert.AreEqual(Date.B, _b);
            Assert.AreEqual(Date.C, _c);
        }

        [TestCase("3", "4", "-5", 76)]
        [TestCase("23", "5", "1", -67)]
        [TestCase("-10", "4", "5", 216)]
        public void FindD_Numbers_ShouldGetCorrectDiscriminant(string a, string b, string c, double d)
        {
            var date = new InputDate(a, b, c);

            date.FindD(date.A,date.B,date.C);
            Assert.AreEqual(date.D, d);           
        }

        [TestCase("1", "-26", "120", 20, 6)]
        [TestCase("1", "372", "3620", -10, -362)]
        [TestCase("-1", "4", "1", -0.2360679774997898, 4.23606797749979)]
        public void SolveAndSaveSolution_NumbersWithCorrectRoot_ShouldReturnCorrectRoots(string a, string b, string c, double r1, double r2)
        {
            Date.SolveAndSaveSolution(a, b, c);

            Assert.AreEqual(Math.Round(Date.R1, 10), Math.Round(r1, 10));
            Assert.AreEqual(Math.Round(Date.R2, 10), Math.Round(r2, 10));
        }

        [TestCase("1", "-1", "1")]
        [TestCase("2", "3", "12")]
        public void FindRoots_Numbers_ShouldThrowNoRootsException(string a, string b, string c)
        {
            var inputDate = new InputDate(a, b, c);

            inputDate.FindD(inputDate.A, inputDate.B, inputDate.C);

            Assert.That(() => inputDate.FindRoots(inputDate.D), Throws.TypeOf<NoRootsException>());
        }

        [TestCase("R#1: 5;R#2: 20;", ".-!238*3@#33!")]
        [TestCase("R#1: 5;R#2: 20;", "nul")]
        [TestCase("R#1: 5;R#2: 20;", null)]
        [TestCase("R#1: 5;R#2: 20;", "aux")]
        public void SaveResult_InvalidPathName_ShouldThrowExeption(string value, string path)
        {
            Assert.That(() => Date.SaveResult(value, path), Throws.Exception);
        }

        [TestCase(null, null, null)]
        [TestCase("1", null, null)]
        [TestCase("1", "2", null)]
        public void SolveAndSaveSolution_WithNullParam_ThrowArgumentNullException(string a, string b, string c)
        {
            var date = new InputDate();

            Assert.That(() => date.SolveAndSaveSolution(a, b, c), Throws.TypeOf<ArgumentNullException>());
        }
    }
}