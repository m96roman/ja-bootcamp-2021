using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SolveEquation;
using System.IO;

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
        public void Test_root_as_0(double a, double b, double c)
        {
            Equation equation = new Equation(a, b, c);

            EquationRoots equationRoots = equation.FindRoots();

            Assert.AreEqual(0, equationRoots.Res1);
            Assert.AreEqual(0, equationRoots.Res2);
        }

        [TestCase(10, 1, 1)]
        public void Test_Discriminant_is_incorrect(double a, double b, double c)
        {
            Assert.That(() => new Equation(a, b, c).Discriminant(), Throws.TypeOf<NoRootsException>());
        }

        [TestCase(3, 6, 3)]
        public void Test_when_discriminant_0(double a, double b, double c)
        {
            Equation equation = new Equation(a, b, c);

            EquationRoots equationRoots = equation.FindRoots();

            Assert.AreEqual(equationRoots.Res1, equationRoots.Res2);
        }

        [TestCase(1, 5, 4, -1, -4)]
        [TestCase(1, 5, 4,-1,-4)]
        public void Test_When_Two_Roots(double a, double b, double c, double res1, double res2)
        {
            Equation equation = new Equation(a, b, c);

            EquationRoots equationRoots = equation.FindRoots();

            Assert.AreEqual(res1, equationRoots.Res1);
            Assert.AreEqual(res2, equationRoots.Res2);
        }

        [Test]
        public void Check_format_When_Two_Roots()
        {
            Mock<ILoger> mock = new Mock<ILoger>();

            Equation equation = new Equation();
            Equation.Loger = mock.Object;

            equation.SolveAndSaveSolution(4, 11, 4, @"C:\Users\Yevhen.shyptur\Desktop\");

            mock.Verify(it => it.Log("< Root #1: -0.4312706956; Root #2: -2.3187293044>"), Times.Once);
        }

        [Test]
        public void Check_format_No_Root_()
        {
            Mock<ILoger> mock = new Mock<ILoger>();
            Equation equation = new Equation();
            Equation.Loger = mock.Object;

            equation.SolveAndSaveSolution(0, 1, 4, @"C:\Users\Yevhen.shyptur\Desktop\");

            mock.Verify(it => it.Log("<No solution>"), Times.Once);
        }

        [Test]
        public void Check_format_One_Root()
        {
            Mock<ILoger> logerMock = new Mock<ILoger>();

            Equation equation = new Equation();
            Equation.Loger = logerMock.Object;
            equation.SolveAndSaveSolution(10, 10, 2.5, @"C:\Users\Yevhen.shyptur\Desktop\");

            logerMock.Verify(it => it.Log("< Root #1: -0.5>"), Times.Once);
        }

        [Test]
        public void Check_file_write()
        {
            Mock<IFileWrapper> fileWrapperMock = new Mock<IFileWrapper>();

            Equation equation = new Equation();
            Equation.FileWrapper1 = fileWrapperMock.Object;
            equation.SolveAndSaveSolution(4, 11, 4, @"C:\Users\Yevhen.shyptur\Desktop\");

            fileWrapperMock.Verify(f => f.WriteToFile(@"C:\Users\Yevhen.shyptur\Desktop\Result.txt", "< Root #1: -0.4312706956; Root #2: -2.3187293044>"),Times.Once);
        }
    }
}