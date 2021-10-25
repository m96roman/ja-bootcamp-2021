using System;

namespace SquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            InputValues inputValues = new ConsoleValueReader().ReadValues();

            SquareEquationSolver instance = new SquareEquationSolver(inputValues);

            instance.CalculateRoots(out double root1, out double root2);

            Console.WriteLine($"Root1: {root1},  root2: {root2}");


            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }
    }

}