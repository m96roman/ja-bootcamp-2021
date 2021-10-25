namespace SquareEquation
{
    public class CalculationService : ICalculationService
    {
        private readonly ISquareEquationService _squareEquationService;
        private readonly IResultSaverService _resultSaverService;

        public CalculationService(ISquareEquationService squareEquationService, IResultSaverService resultSaverService)
        {
            _squareEquationService = squareEquationService;
            _resultSaverService = resultSaverService;
        }

        public void SolveAndSave(double a, double b, double c, string filePath)
        {
            var equationSolution = _squareEquationService.Solve(a, b, c);

            _resultSaverService.Save(equationSolution, filePath);
        }
    }
}
