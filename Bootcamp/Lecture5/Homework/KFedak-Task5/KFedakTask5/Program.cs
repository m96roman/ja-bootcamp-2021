using System;
using System.Collections.Generic;

namespace KFedakTask5
{
    class Program
    {
        public static List<Point> listPoint = new List<Point>();
        public static Circle[] circles;
        static void Main(string[] args)
        {
            CreateObjects();
            Shape.Draw<Point>(listPoint);
            Shape.Draw<Circle>(circles);
        }
        public static void CreateObjects()
        {
            listPoint.Add(new Point(2.5, 4.3));
            listPoint.Add(new Point(3, 8));
            circles = new Circle[] { new Circle(5), new Circle(10) };
        }
    }
}
