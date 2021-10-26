using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveEquation
{
    public class Equation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        internal static ILoger Loger { get; set; } = new Logger();
        internal static IFileWrapper FileWrapper1 { get; set; } = new FileWrapper();

        public Equation(double a, double b, double c)
        {
            InputValue(a, b, c);
        }
        public Equation()
        {

        }
        public void InputValue(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException();
            }
            A = a;
            B = b;
            C = c;

        }
        public double Discriminant()
        {
            if (B * B < 4 * A * C)
            {
                throw new NoRootsException();
            }
            double det = Math.Sqrt(B * B - 4 * A * C);

            return det;
        }
        public void SaveResult(EquationRoots equationRoots, string filePath)
        {
            string result;
            if (equationRoots.Res1 == equationRoots.Res2)
            {
                result = $"< Root #1: {Math.Round(equationRoots.Res1, 10)}>";
            }
            else
            {
                result = equationRoots.ToString();
            }

            
            Loger.Log(result);

            filePath += "Result.txt";

           FileWrapper1.WriteToFile( filePath,  result);
        }

        public void SolveAndSaveSolution(double a, double b, double c, string filePath)
        {
            A = a;
            B = b;
            C = c;
            EquationRoots equationRoots = this.FindRoots();
            SaveResult(equationRoots, filePath);
        }

        public EquationRoots FindRoots()
        {
            try
            {
                double det = Discriminant();

                return new EquationRoots
                {
                    Res1 = (-B + det) / (2 * A),
                    Res2 = (-B - det) / (2 * A)
                };
            }
            catch (NoRootsException ex)
            {
                return new EquationRoots { Res1 = double.NaN };

            }

        }
    }
}
