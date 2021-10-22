using Equation;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationTest
{
    [TestFixture]
    public class IntegrationTest
    {
        [TestCase("Root #1: -1; Root #2: 5",1,-4,-5)]
        [TestCase("Root #1: -3",1,6,9)]
        [TestCase("No solution",1,2,5)]
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
