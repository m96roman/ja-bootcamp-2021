using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationMartin
{
    internal class InputDate
    {
        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }

        public double D { get; private set; }

        public double R1 { get; set; }
        public double R2 { get; set; }


        public InputDate()
        {
        }
        public InputDate(string a, string b, string c) : base()
        {
            ValiDateInputData(a, b, c);
        }

        public void ValiDateInputData(string a, string b, string c)
        {
            if (a.Equals("0"))
            {
                throw new ArgumentException();
            }

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

            SetData(_a, _b, _c);
        }

        private void SetData(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void FindD(double a, double b, double c)
        {
            D = b * b - 4 * (a * c);
        }
        public void FindRoots( double d)
        {
            if (d < 0)
            {
                throw new NoRootsException();
            }

            R1 = (-B + Math.Sqrt(d)) / 2 * A;
            R2 = (-B - Math.Sqrt(d)) / 2 * A;
        }

        public void SolveTheEquation()
        {
            FindD(A, B, C);
            FindRoots(D);
            Console.WriteLine($"{R1}\n{R2}");
        }
    }
}
