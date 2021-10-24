using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace SquareEquation.UnitTests
{
    public class CalculationServiceTests
    {
        private CalculationService _calculationService;
        private Mock<ISquareEquationService> _squareEquationServiceMock;
        private Mock<IResultSaverService> _resultSaverServiceMock;

        [SetUp]
        public void Setup()
        {
            _squareEquationServiceMock = new Mock<ISquareEquationService>();
            _resultSaverServiceMock = new Mock<IResultSaverService>();
            _calculationService = new CalculationService(_squareEquationServiceMock.Object, _resultSaverServiceMock.Object);
        }

        [Test]
        public void SolveAndSave_WorksCorrectly()
        {
            double a = 1;
            double b = 2;
            double c = 3;
            var equationSolution = new List<double>() {1,2};
            var path = "s";

            _squareEquationServiceMock.Setup((p) => p.Solve(a, b, c)).Returns(equationSolution);
            _calculationService.SolveAndSave(a, b, c, path);
            _resultSaverServiceMock.Verify((p) => p.Save(equationSolution, path));
        }
    }
}