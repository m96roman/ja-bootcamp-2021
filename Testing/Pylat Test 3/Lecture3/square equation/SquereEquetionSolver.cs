﻿using System;
using System.Collections.Generic;
using System.Text;

namespace square_equation
{
    public class SquereEquetionSolver : ISquereCalculator
    {
        public List<double> SolveSquereEquation(double a, double b, double c)
        {
            List<double> list = new List<double>();
            double x1;
            double x2;
            double det = SolveD(a, b, c);

            if (det == 0)
            {
                x1 = SolveX1_When_D_Is0(a, b, det);


                Console.Write("X1 and X2 are equal.\n");
                Console.Write("X1= {0}\n", x1);

                list.Add(x1);
                return list;
            }

            else if (det > 0)
            {
                x1 = SolveX1_When_D_MoreThan0(a, b, det);
                x2 = SolveX2_When_D_MoreThan0(a, b, det);

                Console.Write("X1 and X2 are real\n");
                Console.Write("X1 = {0}\n", x1);
                Console.Write("X2= {0}\n", x2);

                list.Add(x1);
                list.Add(x2);
                return list;
            }

            else Console.Write("No Solution. \n\n");
            return list;
        }
        public static double SolveD(double a, double b, double c)
        {
            double d;
            d = b * b - 4 * a * c;
            if (a == 0 || d < 0)
            {
                throw new Exception("a == 0 or d < 0");
            }
            return d;
        }

        public double SolveX1_When_D_MoreThan0(double a, double b, double d)
        {
            return (-b + Math.Sqrt(d)) / (2 * a);
        }

        public double SolveX2_When_D_MoreThan0(double a, double b, double d)
        {
            return (-b - Math.Sqrt(d)) / (2 * a);
        }

        public double SolveX1_When_D_Is0(double a, double b, double d)
        {
            return -b / (2.0 * a);
        }
    }
}