using System;

namespace square_equation
{
    public class Equation
    {
        public static void Main()
        {
            Console.Write("Value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Value of c : ");
            int c = Convert.ToInt32(Console.ReadLine());
        }

        public void SquereEquation(int a, int b, int c)
        { 
            if (SolveD(a, b, c) == 0)
            {
                Console.Write("X1 and X2 are equal.\n");
                SolveX1_When_D_Is0(a, b, SolveD(a, b, c));
                SolveX2_When_D_Is0(a, b, SolveD(a, b, c));

                Console.Write("X1= {0}\n", SolveX1_When_D_Is0(a, b, SolveD(a, b, c)));
                Console.Write("X2= {0}\n", SolveX2_When_D_Is0(a, b, SolveD(a, b, c)));
            }
            else if (SolveD(a, b, c) > 0)
            {
                Console.Write("X1 and X2 are real\n");
                SolveX1When_D_MoreThan0(a, b, SolveD(a, b, c));
                SolveX2When_D_MoreThan0(a, b, SolveD(a, b, c));

                Console.Write("X1 = {0}\n", SolveX1When_D_MoreThan0(a, b, SolveD(a, b, c)));
                Console.Write("X2= {0}\n", SolveX2When_D_MoreThan0(a, b, SolveD(a, b, c)));
            }
            else
                Console.Write("No Solution. \n\n");
        }

        public int SolveD(int a, int b, int c)
        {
            int d;
            d = b * b - 4 * a * c;
            if (a == 0 || d < 0)
            {
                throw new Exception("a == 0 or d < 0");
            }
            return d;
        }

        public double SolveX1When_D_MoreThan0(int a, int b, int d)
        {
            double x1;

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }

        public double SolveX2When_D_MoreThan0(int a, int b, int d)
        {
            double x2;
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }

        public double SolveX1_When_D_Is0(int a, int b, int d)
        {
            double x1;
            x1 = -b / (2.0 * a);
            return x1;
        }
        public double SolveX2_When_D_Is0(int a, int b, int d)
        {
            double x1;
            x1 = -b / (2.0 * a);
            return x1;
        }
    }
}
