using System;
using System.IO;

namespace Equation
{
    public class Program
    {
        public static IFileWrapper fileWrapper = new FileWrapper();

        public static string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");

        public static void Main(string[] args)
        {
            QuadraticFunction quadraticFunction = new()
            {
                FileWrapper = fileWrapper
            };

            quadraticFunction.SolveAndSaveSolution(1, 6, 9, logFilePath);
        }
    }
}
