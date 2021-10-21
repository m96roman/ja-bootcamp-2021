using System;
using System.Runtime.CompilerServices;
using Equation.Models;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation
{
    public class Calculate
    {
        public Calculate() { }

        public double? CalculateDiscriminant(Coefficients coef)
        {
            var result = Math.Pow(coef.B, 2) - 4 * coef.A * coef.C;

            if(result < 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public Roots CalculateRoots(Coefficients coef, double? disc)
        {
            if(disc == 0)
            {
                double r = -coef.B / 2 * coef.A;
                return new Roots { R1 = r, R2 = null };
            }
            else
            {
                double r1 = Math.Round(( (-coef.B + Math.Sqrt(disc.Value)) / 2 * coef.A), 10);
                double r2 = Math.Round(( (-coef.B - Math.Sqrt(disc.Value)) / 2 * coef.A), 10);
                return new Roots { R1 = r1, R2 = r2 }; 
            }
        }
    }
}
