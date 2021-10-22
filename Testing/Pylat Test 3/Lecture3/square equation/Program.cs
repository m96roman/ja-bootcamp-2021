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

            SquereEquetionSolver squere = new SquereEquetionSolver();
            ResultSaver result = new ResultSaver();
            CalculationService calculation = new CalculationService(squere, result);
            var list = squere.SolveSquereEquation(1, 16, 1);
            var exprctedRes = "< Root #1: -0.0627460668062279; Root #2: -15.9372539331938>";

            calculation.SolveAndSave(1, 16, 1, path);

          //Console.WriteLine()
            /*
                        ICalculationService service = new CalculationService(new SquereEquetionSolver(), new ResultSaver());
                        service.SolveAndSave(1, 16, 1, path);*/
        }

    }
}
