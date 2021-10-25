using System;
using System.IO;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TDDSquareEquation.UnitTests")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TDDSquareEquation.IntegrationTests")]

namespace TDDSquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            Solver solver = new();
            solver.SolveAndSave(10, 35, 5, filePath);
        }
    }
}
