using NUnit.Framework;
using QuadraticEquationMartin;
using System;
using Moq;
using System.IO;
using System.Linq;

namespace QuadraticEquationMartinTests
{   
    [TestFixture]
    public class InputDateUnitTests
    {
        private readonly InputDate Date = new InputDate();

        [TestCase(null, "0", null)]
        [TestCase("000", "65", "56")]
        [TestCase(" ", "65", "56")]
        [TestCase("", " ", "")]
        public void Parse_GivenFirstNull_ShouldThrowArgumentException(string a, string b, string c)
        {
            Assert.That(() => Date.ValiDateInputData(a, b, c), Throws.ArgumentException);
        }

        [TestCase("a", "b", "c")]
        [TestCase("asd", "0", "reter")]
        [TestCase("#@2", "a", "43")]
        public void Parse_GivenInvalidInput_ShouldThrowArgumentException(string a, string b, string c)
        {
            Assert.That(() => Date.ValiDateInputData(a, b, c), Throws.ArgumentException);
        }

        [TestCase("1", "2", "5")]
        [TestCase("-321", "2", "21354")]
        [TestCase("1", "-213213.32", "3223.342")]
        public void Parse_GivenCorrectDate_ShouldThrowArgumentException(string a, string b, string c)
        {
            Assert.DoesNotThrow(() => Date.ValiDateInputData(a, b, c));
        }

        [TestCase("1", "-26", "120", 20, 6)]
        [TestCase("1", "372", "3620", -10, -362)]
        [TestCase("-1", "4", "1", -0.2360679774997898, 4.23606797749979)]
        public void Parse_GivenCorrectArgument_ShouldReturnCorrectRoots(string a, string b, string c, double r1, double r2)
        {
            Date.SolveAndSaveSolution(a, b, c);

            Assert.AreEqual(Math.Round(Date.R1, 10), Math.Round(r1, 10));
            Assert.AreEqual(Math.Round(Date.R2, 10), Math.Round(r2, 10));
        }

        [TestCase("1", "-1", "1")]
        [TestCase("2", "3", "12")]
        public void Parse_GivenArgument_ShouldThrowNoRootsException(string a, string b, string c)
        {
            var inputDate = new InputDate(a, b, c);

            inputDate.FindD(inputDate.A, inputDate.B, inputDate.C);

            Assert.That(() => inputDate.FindRoots(inputDate.D), Throws.TypeOf<NoRootsException>());
        }

        [TestCase("R#1: 5;R#2: 20;", "FileResult")]
        [TestCase("R#1: 5;R#2: 20;", "MyFile")]
        public void Parse_GivenArgumentToSaveResult_ShouldCreateFile(string value, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}.txt";

            Date.SaveResult(value, path);

            Assert.IsTrue(File.Exists(pathFile));

            File.Delete(pathFile);
        }

        [TestCase("R#1: 5;R#2: 20;")]
        [TestCase("")]
        public void Parse_GivenEmptytPathToSaveResult_ShouldCreateFile(string value)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\FileResult.txt";

            Date.SaveResult(value);

            Assert.IsTrue(File.Exists(pathFile));

            File.Delete(pathFile);
        }

        [TestCase("R#1: 5;R#2: 20;", ".-!238*3@#33!")]
        [TestCase("R#1: 5;R#2: 20;", "nul")]
        [TestCase("R#1: 5;R#2: 20;", null)]
        [TestCase("R#1: 5;R#2: 20;", "aux")]
        public void Parse_GivenInvalidPathToSaveResult_ShouldThrowExeption(string value, string path)
        {
            Assert.That(() => Date.SaveResult(value, path), Throws.Exception);
        }

        [TestCase("< Root #1: 2; Root #2: 20; >", "Result")]
        [TestCase("< Root #1: -3213; Root #2: 2343243.4332; >", "Result")]
        [TestCase("< Root #1: 234; Root #2: 2389; >", "Result")]
        [TestCase("< Root #1: 0; Root #2: 0; >", "Result")]
        public void Parse_CheckEqualResultInFile(string result, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}.txt";

            Date.SaveResult(result, path);

            Assert.IsTrue(File.ReadAllLines(pathFile)
                .Contains(result));

            File.Delete(pathFile);
        }

        [TestCase(null,null,null)]
        [TestCase("1",null,null)]
        [TestCase("1", "2",null)]
        public void Parse_SolveAndSaveSolution_ThrowArgumentNullException(string a, string b, string c)
        {
            var date = new InputDate();

            Assert.That(() => date.SolveAndSaveSolution(a, b, c), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCase( "1", "2", "1", "< Root #1: -2 >", "FileResult")]
        public void Parse_SolveAndSaveSolutionWithInicializeConstructor_ShouldPassed(string a,string b,string c,string result, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}.txt";
            var date = new InputDate("2","5","1");

            date.SolveAndSaveSolution(a,b,c);

            Assert.IsTrue(File.ReadAllLines(pathFile)
                .Contains(result));

            File.Delete(pathFile);
        }

        [TestCase("1", "2", "1", "< Root #1: -2 >", "FileResult")]
        public void Parse_SolveAndSaveSolutionWithEmptyConstructor_ShouldPassed(string a, string b, string c, string result, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}.txt";

            Date.SolveAndSaveSolution(a, b, c);

            Assert.IsTrue(File.ReadAllLines(pathFile)
                .Contains(result));

            File.Delete(pathFile);
        }
    }
}