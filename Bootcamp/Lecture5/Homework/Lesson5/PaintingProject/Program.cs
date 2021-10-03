using System;
using System.Collections.Generic;

namespace PaintingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<Point>
            {
                new Point(5, 15),
                new Point(14, 32)
            };

            var rectangles = new List<Rectangle>
            {
                new Rectangle(3, 5),
                new Rectangle(14, 33)
            };

            var circles = new List<Circle>
            {
                new Circle(13),
                new Circle(33)
            };

            DrawObject(points);
            DrawObject(rectangles);
            DrawObject(circles);
        }

        public static void DrawObject<T>(IEnumerable<T> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape)
                {
                    case Point:
                        Console.WriteLine("Output from Point");
                        break;
                    case Rectangle:
                        Console.WriteLine("Output from Rectangle");
                        break;
                    case Circle:
                        Console.WriteLine("Output from circle");
                        break;
                }
            }
        }
    }

    public class Point {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public class Rectangle
    {
        public int SideA;
        public int SideB;

        public Rectangle(int sideA, int sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }
    }

    public class Circle
    {
        public double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
    }
}
