using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace SquareEquation.UnitTests
{
    public class CalculationServiceTests
    {
        [Test]
        public void SolveAndSave_WorksCorrectly()
        {
            // Arrange
            Mock<ISquareEquationService> _squareEquationServiceStub;
            Mock<IResultSaverService> _resultSaverServiceMock;
            CalculationService _calculationService;

            Init(out _squareEquationServiceStub, out _resultSaverServiceMock);
            _calculationService = new CalculationService(_squareEquationServiceStub.Object, _resultSaverServiceMock.Object);

            double a = 1;
            double b = 2;
            double c = 3;
            var equationSolution = new List<double>() { 1, 2 };
            var path = "s";

            _squareEquationServiceStub.Setup((p) => p.Solve(a, b, c)).Returns(equationSolution);

            // Act
            _calculationService.SolveAndSave(a, b, c, path);

            // Assert
            _resultSaverServiceMock.Verify((p) => p.Save(equationSolution, path));
        }

        [TestCase(1, 16, 1, -0.06274606680622785, -15.937253933193773)]
        [TestCase(1, 2, 1, -1, -1)]
        [TestCase(1, 2, 5, null, null)]
        public void SolveAndSave_SavesOneTime(double a, double b, double c, double x1, double x2)
        {
            //Arrange
            var path = "s";
            var res = new List<double>() { x1, x2 };

            Mock<ISquareEquationService> _squareEquationServiceStub;
            Mock<IResultSaverService> _resultSaverServiceMock;
            CalculationService _calculationService;

            Init(out _squareEquationServiceStub, out _resultSaverServiceMock);
            _calculationService = new CalculationService(_squareEquationServiceStub.Object, _resultSaverServiceMock.Object);
            _squareEquationServiceStub.Setup((p) => p.Solve(a, b, c)).Returns(res);

            //Act
            _calculationService.SolveAndSave(a, b, c, path);

            //assert
            _resultSaverServiceMock.Verify(it => it.Save(res, path), Times.Once);
        }

        private static void Init(out Mock<ISquareEquationService> _squareEquationServiceStub, out Mock<IResultSaverService> _resultSaverServiceMock)
        {
            _squareEquationServiceStub = new Mock<ISquareEquationService>();
            _resultSaverServiceMock = new Mock<IResultSaverService>();
        }

    }
}