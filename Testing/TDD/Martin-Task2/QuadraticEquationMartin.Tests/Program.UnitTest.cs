using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QuadraticEquationMartin;
namespace QuadraticEquationMartin.UnitTests
{
    [TestFixture]
    class Program
    {
        [TestCase("0", "2", "2")]       
        public void Parse_GivenFirstNull_ShouldThrowArgumentException(string a, string b, string c)
        {               
            var inputDate = new InputDate();
            Assert.That(() => inputDate.ValiDateInputData(a, b, c), Throws.ArgumentException);
        }

    }
}
