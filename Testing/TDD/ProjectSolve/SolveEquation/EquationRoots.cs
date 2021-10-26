using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveEquation
{
    public struct EquationRoots
    {
        public double Res1 { get; set; }
        public double Res2 { get; set; }

        public override string ToString()
        {
            if (double.IsNaN(Res1))
            {
                return "<No solution>";

            }
            else
            {
                return $"< Root #1: {Math.Round(Res1, 10)}; Root #2: {Math.Round(Res2, 10)}>";
            }
            
        }
    }
}
