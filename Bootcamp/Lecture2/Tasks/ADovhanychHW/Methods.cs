using System;

public static class Methods
{
    public static void SwapNum()
    {
        Console.WriteLine("Input first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        ReplaceNums(ref firstNum, ref secondNum);

        Console.WriteLine($"Now the 1st number is : {firstNum} , and the 2nd number is : {secondNum}");

        static void ReplaceNums(ref int numA, ref int numB)
        {
            int temp = numA;
            numA = numB;
            numB = temp;
        }

    }

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public static bool TryParsePoint(out Point point)
        {
            Console.WriteLine("Enter two coordinates ");
            string[] input = Console.ReadLine().Replace(" ", "").Split(",");

            if (input.Length == 2)
            {
                if (int.TryParse(input[0], out int newX) && int.TryParse(input[1], out int newY))
                {
                    point = new Point(newX, newY);
                    return true;
                }
            }
            point = default;
            return false;
        }
        public bool Print()
        {
            if (Point.TryParsePoint(out Point point))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
