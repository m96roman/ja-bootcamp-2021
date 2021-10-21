using Equation;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationTest
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        [TestCase(-1, 5, "Root #1: -1; Root #2: 5")]
        [TestCase(-3, -3, "Root #1: -3")]
        [TestCase(null, null, "No solution")]
        public void FileIsExistsAndCorrectData(double? x1, double? x2, string result)
        {
            //arrange
            Mock<IFileWrapper> fileMock = new();
            QuadraticFunction quadraticFunction = new()
            {
                FileWrapper = fileMock.Object
            };
            var path = Program.logFilePath;

            //act
            quadraticFunction.SaveResult(new Result(x1, x2), path);

            //assert
            fileMock.Verify(it => it.CheckFileExists(path));
            fileMock.Verify(it => it.WriteInFile(path, result));
        }
    }
}
