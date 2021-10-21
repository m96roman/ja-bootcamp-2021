using System;
using System.Collections.Generic;
using System.IO;

namespace square_equation
{
    public class Equation
    {
        public static void Main()
        {
            var path = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Testing\Pylat Test 3\Lecture3\Text.txt";


            ICalculationService service = new CalculationService(new SquereEquetionSolver(), new ResultSaver());
            service.SolveAndSave(1, 16, 1, path);
        }

    }
}
