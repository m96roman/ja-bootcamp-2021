using Exchange_Task;
using NUnit.Framework;
using System.IO;

namespace ExcahangeIntegrationTest
{
    [TestFixture]
    public class Tests
    {
        [TestCase(@"C:\Users\kateryna.fedak\source\repos\m96roman\ja-bootcamp-2021\Testing\UnitTesting\KFedak-Exchanges\ExcahangeIntegrationTest\bin\Debug\net5.0\TestExpextedOutput.txt")]
        public void ChechkValueCalculateConversionInBatches(string expectedResultFile)
        {
            //arrange
            SQLOpeartion sQL = new();
            CalculateConversion calculateConversion = new();

            string filePathInput = Path.Combine(Directory.GetCurrentDirectory(), "TestInput.txt");
            string actualfilePathOutput = Path.Combine(Directory.GetCurrentDirectory(), "TestOutput.txt");

            //act
            calculateConversion.CalculateConversionInBatches(filePathInput, actualfilePathOutput, sQL);

            //assert
            Assert.AreEqual(File.ReadAllText(expectedResultFile).Replace("\r", ""), File.ReadAllText(actualfilePathOutput));
        }
    }
}