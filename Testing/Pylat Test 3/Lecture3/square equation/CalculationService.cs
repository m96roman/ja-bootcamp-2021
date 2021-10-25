namespace square_equation
{
    public class CalculationService : ICalculationService
    {
        private ISquereCalculator _solver;
        private IResultSaver _saver;

        public CalculationService(ISquereCalculator solver, IResultSaver saver)
        {
            _solver = solver;
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
