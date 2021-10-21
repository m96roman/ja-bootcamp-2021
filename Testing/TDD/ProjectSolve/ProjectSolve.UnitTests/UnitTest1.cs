using NUnit.Framework;
using SolveEquation;

namespace ProjectSolve.UnitTests
{
    public class Tests
    {
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 1, 2)]
        [TestCase(0, 2, 0)]
        public void InputValue_A_not_0(double a, double b, double c)
        {
            Assert.That(() => new Equation(a, b, c), Throws.ArgumentException);
        }

        [TestCase(1, 0, 0)]
        public void Test__root_as_0(double a, double b, double c)
        {
            Equation equation = new Equation(a, b, c);
            EquationRoots equationRoots = equation.FindRoots();

            Assert.AreEqual(0, equationRoots.Res1);
            Assert.AreEqual(0, equationRoots.Res2);

        }

        [TestCase(10, 1, 1)]
        public void Test_Discriminant_is_incorrect(double a, double b, double c)
        {
            Equation equation = new Equation(a, b, c);

            Assert.That(() => new Equation(a, b, c).FindRoots(), Throws.TypeOf<NoRootsException>());
        }

        [TestCase(3, 6, 3)]
        public void Test_when_discriminant_0(double a, double b, double c)
        {
            Equation equation = new Equation(a, b, c);
            EquationRoots equationRoots = equation.FindRoots();
            Assert.AreEqual(equationRoots.Res1, equationRoots.Res2);
        }

        [TestCase(1, 5, 4)]
        public void Test_Happy_Path(double a, double b, double c)
        {
            Equation equation = new Equation(a, b, c);
            EquationRoots equationRoots = equation.FindRoots();

            Assert.AreEqual(-1, equationRoots.Res1);
            Assert.AreEqual(-4, equationRoots.Res2);
        }
        
        
    }
}