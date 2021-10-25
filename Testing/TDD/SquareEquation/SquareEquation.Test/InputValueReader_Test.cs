using NUnit.Framework;
using Moq;

namespace SquareEquation.Test
{
    [TestFixture]
    class InputValueReader_Test
    {
        [TestCase(1, 2, 3)]
        [TestCase(-2.5, 0, 3.023)]
        [TestCase(0.0256, -2.3416, 31.02168)]
        public void ReadValues_HappyPath(double a, double b, double c)
        {
            //arrange


            //act


            //assert
            Assert.Fail();
        }


        [TestCase("Error! All values must contains only numbers and/or floating point")]
        public void ReadValues_GivenNotANumber_ShouldPrintError(string errorMsg)
        {
            //arrange
            

            //act


            //assert
            Assert.Fail();
        }

    }
    

}