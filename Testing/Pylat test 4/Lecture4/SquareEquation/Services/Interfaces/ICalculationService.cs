using System;
using System.Collections.Generic;
using System.Text;

namespace SquareEquation
{
    interface ICalculationService
    {
        void SolveAndSave(double a, double b, double c, string filePath);
    }
}
