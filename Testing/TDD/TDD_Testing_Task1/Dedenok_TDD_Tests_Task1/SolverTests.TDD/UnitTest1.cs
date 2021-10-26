using NUnit.Framework;
using SquereEquationSolver;
using System;

namespace TestSquareEquationSolver
{
    [TestFixture]
    public class Tests
    {
        [TestCase(8, 3, 1)]
        [TestCase(1, 1, 1)]
        public void Solve_DeterminantLessThan_0_SouldThrowException(int a, int b, int c)
        {
            //arrange
            EquationSolver solver = new EquationSolver();
          
            //act and assert
            Assert.Throws<NoRootsException>(() => solver.Solver(a, b, c));
        }


        [TestCase(9, 6, 1, -0.3333333333333333)]
        [TestCase(4, 4, 1, -0.5)]
        public void Solve_DeterminantIS_0_ShoulsReturnEqualRoots(int a, int b, int c, double expectedRoot)
        {   
            //arrange
            EquationSolver solver = new EquationSolver();

            //act
            EquationRoots resultRoots = solver.Solver(a, b, c);

            //assert
            Assert.AreEqual(expectedRoot, resultRoots.R1, 1e-13);
            Assert.AreEqual(expectedRoot, resultRoots.R2, 1e-13);
        }


        [TestCase(10, 15, 1, -0.0699264745632278, -1.4300735254367722)]
        [TestCase(2, 10, 1, -0.10208423834364044, -4.89791576165636)]
        public void Solve_DeterminantMoreThan_0_ShoulsReturnTwoRoots(int a, int b, int c, double expectedRoot1, double expectedRoot2)
        {
            //arrange
            EquationSolver solver = new EquationSolver();
           
            //act
            EquationRoots resultRoots = solver.Solver(a, b, c);
           
            //assert
            Assert.AreEqual(expectedRoot1, resultRoots.R1, 1e-13);
            Assert.AreEqual(expectedRoot2, resultRoots.R2, 1e-13);
        }
    }
}