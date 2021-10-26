using System;

namespace SquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var values = new ConsoleValueReader().ReadValues();

            SquareEquationSolver instance = new SquareEquationSolver();

            EquationSolution result = instance.Solve(values.a, values.b, values.c);
            instance.SaveResult(result, "..\\..\\..\\test.txt");

            Console.WriteLine($"Root1: {result.Root1},  Root2: {result.Root2}");


            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }
    }

}