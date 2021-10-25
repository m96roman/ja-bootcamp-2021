using System.Collections.Generic;

namespace SquareEquation
{
    public interface ISquareEquationService
    {
        List<double> Solve(double a, double b, double c);
    }
}
