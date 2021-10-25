using NUnit.Framework;

namespace SquareEquation.Test
{
    [TestFixture]
    public class QuadraticEquation_Test
    {
        [TestCase("\'A\' cannot be zero, otherwise it is a linear equation!")]
        public void CalculateRoots_Given_A_IsZero_ShouldLogErrorMessage(string errorMsg)
        {
            //arrange


            //act


            //assert
            Assert.Fail();
        }


        [TestCase(1 ,3, 2, -1, -2)]
        [TestCase(1, -6, 0, 6, 0)]
        [TestCase(1, -6, 0, 6, 0)]
        [TestCase(-6, 12, 5, -0.3540, 2.3540)]
        public void CalculateRoots_GivenCoefficients_ShouldReturnCorrectRoots(double a, double b, double c, double root1, double root2)
        {
            //given a-1 b-3 c-2, should return roots: -1, -2
            //arrange


            //act


            //assert
            Assert.Fail();
        }


        [TestCase(1, 2, 1, -1)]
        public void CalculateRoots_GivenCoefficients_ShouldReturn_OnlyOneRoot(double a, double b, double c, double root)
        {
            //given a-1 b-3 c-2, should return roots: -1, -2
            //arrange


            //act


            //assert
            Assert.Fail();
        }


        [TestCase(1,2,2)]
        public void CalculateRoots_GivenCoefficients_ShouldNot_ReturnRoots(double a, double b, double c)
        {
            //given a-1 b-3 c-2, should return roots: -1, -2
            //arrange


            //act


            //assert
            Assert.Fail();
        }
    }

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
        public void ReadValues_GivenStrings_ShouldPrintError(string errorMsg)
        {
            //arrange


            //act


            //assert
            Assert.Fail();
        }

    }
    

}