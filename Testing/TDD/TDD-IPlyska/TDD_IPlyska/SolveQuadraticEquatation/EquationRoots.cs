using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveQuadraticEquatation
{
    internal struct EquationRoots
    {
        public double? R1 { get; set; }
        public double? R2 { get; set; }

        public EquationRoots(double? r1 = null, double? r2 = null)
        {
            R1 = r1;
            R2 = r2;
        }

        public override string ToString() => $"<Root #1: {R1}; Root #2: {R2}>";
    }
}
