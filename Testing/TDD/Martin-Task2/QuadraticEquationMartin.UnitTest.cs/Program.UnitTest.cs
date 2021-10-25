using NUnit.Framework;
namespace QuadraticEquationMartin.UnitTests
{
    [TestFixture]
    class ProgramUnitTest
    {
        [TestCase("0", "2", "2")]       
        public void Parse_GivenFirstNull_ShouldThrowArgumentException(string a, string b, string c)
        {               
            var inputDate = new InputDate();
            Assert.That(() => inputDate.ValidateInputData(a, b, c), Throws.ArgumentException);
        }

    }
}
