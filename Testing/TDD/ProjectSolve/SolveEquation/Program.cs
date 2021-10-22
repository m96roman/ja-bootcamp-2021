using System;
using System.Linq;
using System.Runtime.Serialization;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ProjectSolve.UnitTests")]
namespace SolveEquation
{
    internal partial class Program
    {

        public static void Main(string[] args)
        {
            //Equation equation = new Equation(1, 5, 4);
            //EquationRoots equationRoots = equation.FindRoots();

            //Console.WriteLine(equationRoots.ToString());
                           
            Equation equation = new Equation();
            equation.SolveAndSaveSolution(4, 11, 4, @"C:\Users\Yevhen.shyptur\Desktop\");
        }
    }  
}





