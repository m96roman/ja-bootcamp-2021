using System.Runtime.CompilerServices;
using Equation.Models;
using Equation.Interfaces;
using System.IO;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation
{
    public class Program
    {
        public static IFileWrapper wrapper { get; set; } = new FileWrapper();
        public static readonly string filePath = $@"{Directory.GetCurrentDirectory()}\roots.txt";

        static void Main(string[] args)
        {
            Coefficients coef = new Coefficients { A = -1, B = -2, C = 15 };
            SquareEquationSolver solve = new SquareEquationSolver()
            {
                Wrapper = wrapper
            };
            solve.SolveAndSaveSolution(coef, filePath);
        }
    }
}
