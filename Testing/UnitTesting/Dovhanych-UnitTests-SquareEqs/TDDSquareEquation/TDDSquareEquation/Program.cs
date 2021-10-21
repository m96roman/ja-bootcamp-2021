﻿using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("SquareEquationTests")]

namespace TDDSquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the first coeficient");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the second coeficient");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the constant");
            //double c = Convert.ToDouble(Console.ReadLine());

            //SquareEquation squareEquation = new SquareEquation();

            //var disc = squareEquation.FindDiscriminant(a, b, c);
            //Console.WriteLine($"Discriminant equals: {disc} \n");

            //var twoRoots = squareEquation.SquareEquationSolution(a, b, c);
            //Console.WriteLine($"Solution for the problem is: x1 = {twoRoots.Root1}, x2 = {twoRoots.Root2}");

            Solver solver = new Solver();

            solver.SolveAndSave(5, 2, 1);
        }
    }
}
