using System;
using System.Runtime.CompilerServices;
using Equation.Models;
using Equation.Exceptions;
using Equation.Interfaces;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation
{
    public class Program
    {
        public static ILogger _Logger { get; set; } = new Logger();

        static void Main(string[] args)
        {
            Coefficients coef = InputCoefficients();
            Solve(coef);                
        }

        public static void Solve(Coefficients coef)
        {
            Calculate calc = new Calculate();

            double? disc = calc.CalculateDiscriminant(coef);

            if (!disc.HasValue)
            {
                //throw new DiscriminantException(message: "No root! Discriminant < 0");
                Console.WriteLine("No root! Discriminant < 0");
                _Logger.LogMessage("No root! Discriminant < 0");

            }
            else
            {
                Console.WriteLine($"Discriminant -> {disc}");
                _Logger.LogMessage($"Discriminant -> {disc}");

                Roots roots = calc.CalculateRoots(coef, disc);
                PrintRoots(roots);
            }
        }

        public static void PrintRoots(Roots roots)
        {
            if(roots.R1.HasValue && roots.R2.HasValue)
            {
                Console.WriteLine($"Root 1 -> {roots.R1} Root 2 -> {roots.R2}");
            }
            else
            {
                Console.WriteLine($"Root -> {roots.R1}");
            }
        }

        public static Coefficients InputCoefficients()
        {
            Console.WriteLine("Enter a -> ");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b -> ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c -> ");
            double c = Double.Parse(Console.ReadLine());

            return new Coefficients { A = a, B = b, C = c };
        }
    }
}
