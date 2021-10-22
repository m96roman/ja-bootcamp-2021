using Equation;
using NUnit.Framework;
using System.IO;

namespace IntegrationTest
{
    [TestFixture]
    public class Tests
    {
        [TestCase("Root #1: -1; Root #2: 5", 1, -4, -5)]
        [TestCase("Root #1: -3", 1, 6, 9)]
        [TestCase("No solution", 1, 2, 5)]
        public void FileIsExistsAndCorrectData(string result, double a, double b, double c)
        {
            //arrange
            IFileWrapper fileWrapper = new FileWrapper();
            QuadraticFunction quadraticFunction = new()
            {
                FileWrapper = fileWrapper
            };
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");

            //act
            quadraticFunction.SolveAndSaveSolution(a, b, c, filePath);

            //assert
            Assert.AreEqual(result, File.ReadAllText(filePath));
        }
    }

}