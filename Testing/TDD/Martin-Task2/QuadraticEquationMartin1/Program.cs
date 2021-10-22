using System;
using System.IO;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("QuadraticEquationMartin.UnitTests")]

namespace QuadraticEquationMartin
{
    public class ProgramUnitTests
    {
        static void Main(string[] args)
        {     
          /*  string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            */
            InputDate date = new InputDate();
            date.SaveResult("sda", "nul");
            /*date.SolveAndSaveSolution(a,b,c);*/
        }
    }
}
