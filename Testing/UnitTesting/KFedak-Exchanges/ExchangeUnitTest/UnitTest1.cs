using NUnit.Framework;
using Exchange_Task;
using System.IO;
using System;

namespace ExchangeUnitTest
{
    [TestFixture]
    public class Tests
    {
        [TestCase("EUR",100,86.00)]
        public void CheckValueCalculateConversionRate(string currency,decimal amount, decimal answear)
        {
            //arrange
            SQLOpeartion sQL = new();
            CalculateConversion calculateConversion = new();
            
            //act
            decimal result=calculateConversion.CalculateConversionRate(currency, amount, sQL);

            //asert
            Assert.AreEqual(answear, result);
        }

        [TestCase(@"C:\Users\kateryna.fedak\source\repos\m96roman\ja-bootcamp-2021\Testing\UnitTesting\KFedak-Exchanges\ExchangeUnitTest\bin\Debug\net5.0\TestExpextedOutput.txt")]
        public void ChechkValueCalculateConversionInBatches (string expectedResultFile)
        {
            //arrange
            SQLOpeartion sQL = new();
            CalculateConversion calculateConversion = new();
            string filePathInput = Path.Combine(Directory.GetCurrentDirectory(), "TestInput.txt");
            string filePathOutput = Path.Combine(Directory.GetCurrentDirectory(), "TestOutput.txt");

            //act
            calculateConversion.CalculateConversionInBatches(filePathInput, filePathOutput, sQL);

            //assert
            Assert.AreEqual(File.ReadAllText(expectedResultFile).Replace("\r", ""), File.ReadAllText(filePathOutput));
        }

        [TestCase("hello")]
        [TestCase("KO2")]
        [TestCase("111")]
        [TestCase("eu!")]
        public void IsCorrectCurrency(string currency)
        {
            //arrange
            Validation validation = new();

            //act&&assert
            Assert.IsFalse(validation.IsCorrectCurrency(currency));
        }

        [TestCase("-34.77")]
        [TestCase("0.00")]
        [TestCase("00.77")]
        [TestCase("24.dfgg")]
        [TestCase("24,22")]
        public void IsCorrectRate(string rate)
        {
            //arrange
            Validation validation = new();

            //act&&assert
            Assert.IsFalse(validation.IsCorrectRate(rate));
        }

        [TestCase("UAH")]
        [TestCase("USD")]
        [TestCase("RUB")]
        public void HasThisCurrency(string currency)
        {
            //arrange
            Validation validation = new();

            //act&&assert
            Assert.IsFalse(validation.HasThisCurrency(currency));
        }

        [TestCase("-34.77")]
        [TestCase("0.00")]
        [TestCase("00.77")]
        [TestCase("24.dfgg")]
        [TestCase("24,22")]
        public void IsCorrectAmount(string rate)
        {
            //arrange
            Validation validation = new();

            //act&&assert
            Assert.IsFalse(validation.IsCorrectAmount(rate));
        }

        [TestCase("summer-winter?.txt")]
        [TestCase("he&llo/txt")]
        [TestCase("00.7\n7")]
        [TestCase("24.dfg><g")]
        public void IsCorrectFileName(string fileName)
        {
            //arrange
            Validation validation = new();

            //act&&assert
            Assert.IsFalse(validation.IsCorrectFileName(fileName));
        }

        [TestCase("EUR","-100", "Incorrect rate!")]
        [TestCase("Dollar", "100", "Incorrect currency!")]
        [TestCase("FR3", "0.00", "Incorrect rate and currency!")]
        public void CheckMessageIncorrectDataToUpdate(string currency, string rate,string answear)
        {
            //arrange
            var output = new StringWriter();
            Console.SetOut(output);
            Validation validation = new();

            //act
            validation.IncorrectDataToUpdate(currency,rate);

            //assert
            Assert.That(output.ToString().Trim('\n','\r'), Is.EqualTo(answear));
        }

        [TestCase("EUR", "-100", "Incorrect amount!")]
        [TestCase("Dollar", "100", "Incorrect currency!")]
        [TestCase("FR3", "0.00", "Incorrect amount and currency!")]
        public void CheckMessageIncorrectDataToConversion(string currency, string amount, string answear)
        {
            //arrange
            var output = new StringWriter();
            Console.SetOut(output);
            Validation validation = new();

            //act
            validation.IncorrectDataToConversion(currency, amount);

            //assert
            Assert.That(output.ToString().Trim('\n', '\r'), Is.EqualTo(answear));
        }

    }
}