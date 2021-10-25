using QuadraticEquationMartin1;
using System;
using System.IO;


namespace QuadraticEquationMartin
{
    public class InputDate
    {
        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }

        public double D { get; private set; }

        public double R1 { get; private set; }

        public double R2 { get; private set; }

        public string Result { get; private set; }

        private bool InicializeDateState { get; set; }

        public InputDate()
        {
            InicializeDateState = false;
        }

        public InputDate(string a, string b, string c) : base()
        {
            ValidateInputData(a, b, c);
        }

        public void ValidateInputData(string a, string b, string c)
        {
            if (!double.TryParse(a, out var _a))
            {
                throw new ArgumentException();
            }

            if (!double.TryParse(b, out var _b))
            {
                throw new ArgumentException();
            }

            if (!double.TryParse(c, out var _c))
            {
                throw new ArgumentException();
            }

            if (_a.Equals(0))
            {
                throw new ArgumentException();
            }

            SetData(_a, _b, _c);
        }

        private void SetData(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            InicializeDateState = true;
        }

        public void FindD(double a, double b, double c)
        {
            D = b * b - 4 * (a * c);
        }

        public void FindRoots(double d)
        {
            if (d < 0)
            {
                Result = $"<No solution>";
                SaveResult(Result);
                throw new NoRootsException();
            }
            else
            if (d == 0)
            {
                R1 = -B / A;
                Result = $"< Root #1: {Math.Round(R1, 10)} >";
            }
            else
            if (d > 0)
            {
                R1 = (-B + Math.Sqrt(d)) / 2 * A;
                R2 = (-B - Math.Sqrt(d)) / 2 * A;

                Result = $"< Root #1: {Math.Round(R1, 10)}; Root #2: {Math.Round(R2, 10)}; >";
            }
            new Logger(Result).WriteLine();
        }

        public void SolveAndSaveSolution(string a = null, string b = null, string c = null, string filePath = "FileResult")
        {
            if (InicializeDateState == false && (a == null || b == null || c == null))
            {
                throw new ArgumentNullException();
            }
            if (a != null && b != null && c != null)
            {
                ValidateInputData($"{a}", $"{b}", $"{c}");
            }

            FindD(A, B, C);
            FindRoots(D);
            SaveResult(Result, filePath);
        }
        public void SaveResult(string result, string filePath = "FileResult.txt")
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new Exception();
            }
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
