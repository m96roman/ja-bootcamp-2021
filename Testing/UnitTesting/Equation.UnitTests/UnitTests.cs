using NUnit.Framework;
using Equation.Models;
using Equation;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private static SquareEquationSolver solve = new SquareEquationSolver();

        [TestCase(2.4, 5.8, 1.2, 22.12, -1.3161715122, -12.6038284878)]
        public void CalculateRoots_ShouldReturnTwoRootsExpected
            (double a, double b, double c, double disc, double expectedRoot1, double expectedRoot2)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };
            Roots roots = solve.CalculateRoots(coef, disc);

            Assert.AreEqual(expectedRoot1, roots.R1.Value);
            Assert.AreEqual(expectedRoot2, roots.R2.Value);
        }

        [TestCase(1, -2, -3, 16)]
        [TestCase(-1, -2, 15, 64)]
        public void CalculateRoots_ShouldReturnTwoRoots(double a, double b, double c, double disc)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };
            Roots roots = solve.CalculateRoots(coef, disc);

            Assert.That(roots.R1.HasValue && roots.R2.HasValue);
        }

        [TestCase(1, 12, 36, 0)]
        [TestCase(1, -6, 9, 0)]
        public void CalculateRoots_ShouldReturnOneRoot(double a, double b, double c, double disc)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };
            Roots roots = solve.CalculateRoots(coef, disc);

            Assert.That(roots.R1.HasValue && !roots.R2.HasValue);
        }

        [TestCase(1, -6, 9, 0, 3)]
        public void CalculateRoots_ShouldReturnOneRootSimilarToGiven(double a, double b, double c, double disc, double expectedroot)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };
            Roots roots = solve.CalculateRoots(coef, disc);

            Assert.AreEqual(expectedroot, roots.R1.Value);
        }

        [TestCase(1, -8, 12, 6, 2)]
        [TestCase(1, -2, -3, 3, -1)]
        [TestCase(-1, -2, 15, -5, 3)]
        public void Solve_ShouldReturnTwoRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };

            Roots roots = solve.Solve(coef);

            Assert.AreEqual(expectedRoot1, roots.R1.Value);
            Assert.AreEqual(expectedRoot2, roots.R2.Value);
        }

        [TestCase(5, 3, 7)]
        public void Solve_ShouldReturnDiscriminantException(double a, double b, double c)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };

            Assert.That(() => solve.Solve(coef),
                Throws.TypeOf<Equation.Exceptions.NoRootsException>().With.Message.EqualTo("No root! Discriminant < 0"));
        }

        [TestCase(1, -8, 12)]
        [TestCase(1, -6, 9)]
        public void CalculateDiscriminant_ShouldReturnDiscriminant(double a, double b, double c)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };

            Assert.NotNull(solve.CalculateDiscriminant(coef));
        }

        [TestCase(5, 3, 7)]
        public void CalculateDiscriminant_ShouldReturnNullIfNotRoots(double a, double b, double c)
        {
            Coefficients coef = new Coefficients { A = a, B = b, C = c };

            Assert.IsNull(solve.CalculateDiscriminant(coef));
        }
    }
}