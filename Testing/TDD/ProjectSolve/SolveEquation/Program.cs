using System;
using System.Runtime.Serialization;

namespace SolveEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation = new Equation(1, 5, 4);
            EquationRoots equationRoots = equation.FindRoots();

            Console.WriteLine(equationRoots.Res1.ToString());
            Console.WriteLine(equationRoots.Res2.ToString());
        }
    
    }

    public class Equation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Equation(double a, double b, double c)
        {
            InputValue(a, b, c);
        }
        public void InputValue(double a, double b, double c)
        {
            if (a==0)
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
            double det=Math.Sqrt(B * B - 4 * A * C);

            return det;
        }
      
        public  EquationRoots FindRoots()
        {
            double det = Discriminant();



            return new EquationRoots
            {
                Res1 = (-B + det) / (2 * A),
                Res2 = (-B - det) / (2 * A)
            };
        }
    }
    public struct EquationRoots
    {
        public double Res1 { get; set; }
        public double Res2 { get; set; }
    }
    public class NoRootsException : Exception
    {
        public NoRootsException()
        {
        }

        public NoRootsException(string message) : base(message)
        {
        }

        public NoRootsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoRootsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}





