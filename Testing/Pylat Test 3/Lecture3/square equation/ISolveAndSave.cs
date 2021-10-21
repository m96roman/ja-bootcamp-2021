using System;
using System.Collections.Generic;
using System.Text;

namespace square_equation
{
    interface ICalculationService
    {
        void SolveAndSave(double a, double b, double c, string filePath);
    }
}
