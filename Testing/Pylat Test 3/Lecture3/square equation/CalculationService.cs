namespace square_equation
{
    public class CalculationService : ICalculationService
    {
        private ISquereCalculator _solver;
        private IResultSaver _saver;

        public CalculationService(ISquereCalculator sover, IResultSaver saver)
        {
            _solver = sover;
            _saver = saver;
        }

        public void SolveAndSave(double a, double b, double c, string filePath)
        {
            var eqiationSolution = _solver.SolveSquereEquation(a, b, c);

           // eqiationSolution.Add(22);

           _saver.SaveResult(eqiationSolution, filePath);
         }
    }
}
