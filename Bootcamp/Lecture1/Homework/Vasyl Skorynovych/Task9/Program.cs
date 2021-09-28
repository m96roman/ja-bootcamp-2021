using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius: ");
            int circleRadius = Convert.ToInt32(Console.ReadLine());

            double perimeter = 2 * Math.PI * circleRadius;
            double area = Math.PI * Math.Pow(circleRadius, 2);

            Console.WriteLine("Circle perimeter = " + perimeter);
            Console.WriteLine("Circle area = " + area);
        }
    }
}
