using System;
using System.Collections.Generic;
using System.IO;

namespace SquareEquation
{
    public class Equation
    {
        public static void Main()
        {
         string path = @"C:\Users\Admin\Desktop\JustAnswer\ja-bootcamp-2021\Testing\Pylat test 4\Lecture4\File.txt";

            SquareEquationService squere = new SquareEquationService();
            ResultSaverService result = new ResultSaverService();
            CalculationService calculation = new CalculationService(squere, result);
            
            calculation.SolveAndSave(1, 16, 1, path);
            Console.WriteLine(File.ReadAllText(path));

          //Console.WriteLine()
            /*
                        ICalculationService service = new CalculationService(new SquereEquetionSolver(), new ResultSaver());
                        service.SolveAndSave(1, 16, 1, path);*/
        }

    }
}
