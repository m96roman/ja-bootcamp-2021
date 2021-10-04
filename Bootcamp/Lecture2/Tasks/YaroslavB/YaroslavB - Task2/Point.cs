namespace Task2
{
    /// <summary>
    /// ==== Methods =====
    /// Task 2
    /// </summary>
    struct Point
    {
        public int X { get; }

        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;

            Y = y;
        }

        public override string ToString()
        {
            return $"Point = ({X}, {Y})";
        }
    }
}
