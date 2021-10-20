using NUnit.Framework;
using square_equation;

namespace Tests
{
    public class Tests
    {
        readonly Equation equation = new Equation();
        
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,16,1)]
        public void Test1(int a, int b, int c)
        {
            equation.SquereEquation(a,b,c);
            Assert.AreEqual(-0.0627460668062279,equation.SolveX1When_D_MoreThan0(a,b, equation.SolveD(a,b,c)),0.000001);
        }

        [TestCase(1, 16, 1)]
        public void Test2(int a, int b, int c)
        {
            Assert.NotNull(equation.SolveD(a, b, c));
        }

        /*[Test]
        public void Test3()
        {
            Assert.Positive(d);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(0,d);
            Assert.AreEqual(firstX,x1 );
            Assert.AreEqual(secondX, x2);

        }*/
    }
}