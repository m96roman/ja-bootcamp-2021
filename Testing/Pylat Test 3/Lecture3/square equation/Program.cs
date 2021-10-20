using System;

namespace square_equation
{
    using System;
    public class Equation
    {
        public static void Main()
        {
            Console.Write("Input the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of c : ");
            int c = Convert.ToInt32(Console.ReadLine());
        }

        public void SquereEquation(int a, int b, int c)
        {
            Console.Write("\n\n");
            Console.Write("Calculate X1 and X2 of Quadratic Equation :\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n\n");

            if (SolveD(a, b, c) == 0)
            {
                Console.Write("Both roots are equal.\n");
                SolveX1_X2_When_D_Is0(a, b, SolveD(a, b, c));

                Console.Write("X1= {0}\n", SolveX1_X2_When_D_Is0(a, b, SolveD(a, b, c)));
                Console.Write("X2= {0}\n", SolveX1_X2_When_D_Is0(a, b, SolveD(a, b, c)));
            }
            else if (SolveD(a, b, c) > 0)
            {
                Console.Write("Both roots are real and diff-2\n");
                SolveX1When_D_MoreThan0(a, b, SolveD(a, b, c));
                SolveX2When_D_MoreThan0(a, b, SolveD(a, b, c));

                Console.Write("X1 = {0}\n", SolveX1When_D_MoreThan0(a, b, SolveD(a, b, c)));
                Console.Write("X2= {0}\n", SolveX2When_D_MoreThan0(a, b, SolveD(a, b, c)));
            }
            else
                Console.Write("X1 and X2 are imeainary;\nNo Solution. \n\n");
        }

        public int SolveD(int a, int b, int c)
        {
            int d;
            d = b * b - 4 * a * c;
            return d;
        }

        public  double SolveX1When_D_MoreThan0(int a, int b, int d)
        {
            double x1;

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }

        public  double SolveX2When_D_MoreThan0(int a, int b, int d)
        {
            double x2;
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }

        public  double SolveX1_X2_When_D_Is0(int a, int b, int d)
        {
            double x1;
            x1 = -b / (2.0 * a);
            return x1;
        }
    }
}
