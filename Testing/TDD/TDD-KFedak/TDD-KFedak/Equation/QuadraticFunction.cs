using System;
using System.IO;

namespace Equation

{
    public class QuadraticFunction
    {
        public IFileWrapper FileWrapper { get; set; } = new FileWrapper();

        public QuadraticFunction()
        {
            
        }

        public Result DeltaBiggerThanZero(double a, double b,double c)
        {
            var x1 = (-b - Math.Sqrt(CalculateDelta(a,b,c))) / 2 * a;
            var x2 = (-b + Math.Sqrt(CalculateDelta(a,b,c))) / 2 * a;

            return new Result(x1, x2);
        }

        public Result DeltaEqualZero(double a, double b)
        {
            var root = (-b) / 2 * a;

            return new Result(root, root);
        }

        public double CalculateDelta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public Result Slove(double a, double b, double c)
        {
            var delta = CalculateDelta(a,b,c);

            if (delta < 0)
            {
                throw new NoSolution(this,"No solution");
            }
            else if (delta == 0)
            {
                return DeltaEqualZero(a, b);
            }
            else
            {
                return DeltaBiggerThanZero(a, b,c);
            }
        }

        public void SaveResult(Result result, string filePath, string equation)
        {
            if (result.X1 == result.X2 && result.X1!=null)
            {
                FileWrapper.WriteInFile(filePath, $"Root #1: {result.X1}");
            }
            else if (result.X1 != result.X2)
            {
                FileWrapper.WriteInFile(filePath, $"Root #1: {result.X1}; Root #2: {result.X2}");
            }
            else 
            {
                FileWrapper.WriteInFile(filePath, $"No solution");
            }
        }

        public void SolveAndSaveSolution(double a, double b, double c, string filePath)
        {
            //var equation = $"{a}x^2+{b}x+{c}=0";
            var equation = "";
            var root = new Result(0,0);
            try
            {
                 root = Slove(a, b, c);
            }
            catch(NoSolution)
            {
                root = new Result(null, null);
            }
            finally
            {
                SaveResult(root, filePath, equation);
            }
        }

    }
}