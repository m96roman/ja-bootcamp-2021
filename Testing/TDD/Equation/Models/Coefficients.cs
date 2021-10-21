using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation.Models
{
    public class Coefficients
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
    }
}
