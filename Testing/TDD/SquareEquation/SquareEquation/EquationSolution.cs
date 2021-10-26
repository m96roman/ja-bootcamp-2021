namespace SquareEquation
{
    public struct EquationSolution
    { 
        public double Root1 { get; }
        public double Root2 { get; }
    
        public EquationSolution(double root1, double root2)
        {
            Root1 = root1;
            Root2 = root2;
        }
    }

}