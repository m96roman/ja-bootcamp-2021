using System;
using System.IO;
using System.Collections.Generic;

namespace SquareEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Directory.GetCurrentDirectory();
            Console.WriteLine(directoryPath);
        }
    }

    public interface ISaveResultWrapper
    {
        public void SaveResult(string result, string filePath) { }

    }
    public class SaveResultWrapper: ISaveResultWrapper
    {
        public void SaveResult(string result, string filePath)
        {
            File.WriteAllText(filePath, result);
        }
    }

    public class Solver
    {
        public static ISaveResultWrapper Wrapper { get; set; } = new SaveResultWrapper();
       
        public static string FindRoots(double a, double b, double c)
        {
            List<double> resultedRoots = new();

            string message = $"<No solution>";

            double determinant = Math.Sqrt(b * b - 4 * a * c);

            if (determinant > 0)
            {
                resultedRoots.Add((-b + determinant) / (2 * a));
                resultedRoots.Add((-b - determinant) / (2 * a));

                double rootDouble1 = Math.Round(resultedRoots[0], 10);
                double rootDouble2 = Math.Round(resultedRoots[1], 10);

                string root1 = rootDouble1.ToString();
                string root2 = rootDouble2.ToString();

                message = $"<Root #1: {root1}; Root #2: {root2};>";
            }

            if (determinant == 0)
            {
                resultedRoots.Add((-b + determinant) / (2 * a));

                double rootDouble1 = Math.Round(resultedRoots[0], 10);
          
                string root1 = rootDouble1.ToString();
              
                message = $"<Root #1: {root1};>";
            }

            return message;
        }

        public void SaveResult(string result, string filePath)
        {
            Wrapper.SaveResult(result, filePath);
        }

        public void SolveAndSaveSolution(double a, double b, double c, string filePath)
        {
            string res = FindRoots(a, b, c);
            SaveResult(res, filePath);
        }
    }
}




