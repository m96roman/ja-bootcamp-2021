namespace Task2_Ivanyshyn.MethodTasks
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public static bool TryParsePoint(string stringToParse, out Point point)
        {
            if (!string.IsNullOrWhiteSpace(stringToParse) && stringToParse.Contains(','))
            {

                var coordinates = stringToParse.Trim().Split(',');
                if (coordinates.Length == 2)
                {
                    if (int.TryParse(coordinates[0], out int x) && int.TryParse(coordinates[1], out int y))
                    {
                        point = new Point(x, y);
                        return true;
                    }
                }


            }
            point = default;
            return false;
        }

    }
}