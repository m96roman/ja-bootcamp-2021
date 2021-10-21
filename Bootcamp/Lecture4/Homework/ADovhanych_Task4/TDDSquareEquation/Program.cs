using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("SquareEquationUnitTests")]

namespace TDDSquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first coeficient");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second coeficient");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the constant");
            double c = Convert.ToDouble(Console.ReadLine());
        }        
    }
}
