using System;
using System.IO;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("SquareEquationTests")]

namespace TDDSquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            Solver solver = new();
            solver.SolveAndSave(290, 20, 4, filePath);
        }
    }
}
