using System;

namespace Task9
{
    class Task9
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double perimetr = 2 * Math.PI * radius;
            Console.WriteLine($"Perimetr : {perimetr}\nArea : {area}");
        }
    }
}
