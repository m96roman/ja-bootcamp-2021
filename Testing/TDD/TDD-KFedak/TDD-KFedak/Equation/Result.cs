namespace Equation
{
    public class Result
    {
        public double? X1 { get; set; }
        public double? X2 { get; set; }

        public Result(double? x1, double? x2)
        {
            this.X1 = x1;
            this.X2 = x2;
        }
    }
}