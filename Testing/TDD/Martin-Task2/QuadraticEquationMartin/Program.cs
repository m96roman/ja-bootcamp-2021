using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("QuadraticEquationMartin.UnitTests")]

namespace QuadraticEquationMartin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputDate date = new InputDate("1","372","3620");
            date.SolveTheEquation();
        }



    }
}
