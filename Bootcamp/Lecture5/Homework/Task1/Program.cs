using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionPoints = new List<Point>
            {
                new Point
                {
                    Name = "FirstPoint",
                    ColorIndex = 23
                },
                new Point
                {
                    Name = "SecondPoint",
                    ColorIndex = 45
                }
            };

            var collectionRectangles = new List<Rectangle>
            {
                new Rectangle
                {
                    Name = "FirstRectangle",
                    ColorName = "Yellow"
                },
                new Rectangle
                {
                    Name = "SecondRectangle",
                    ColorName = "Green"
                }
            };

            var collectionCircles = new List<Circle>
            {
                new Circle
                {
                    Name = "FirstCircle",
                    Radius = 5
                },
                new Circle
                {
                    Name = "SecondCircle",
                    Radius = 8
                }
            };

            Draw(collectionPoints);
            Draw(collectionRectangles);
            Draw(collectionCircles);
        }

        public abstract class Figure
        {
            public string Name { get; set; }
            public abstract void PrintFigureName();
        }

        public class Point : Figure
        {
            public int ColorIndex { get; set; }
            public override void PrintFigureName()
            {
                Console.WriteLine($"Figure name -> {Name} Color index -> {ColorIndex}");
            }
        }

        public class Rectangle : Figure
        {
            public string ColorName { get; set; }
            public override void PrintFigureName()
            {
                Console.WriteLine($"Figure name -> {Name} Color name -> {ColorName}");
            }
        }

        public class Circle : Figure
        {
            public int Radius { get; set; }
            public override void PrintFigureName()
            {
                Console.WriteLine($"Figure name -> {Name} Radius -> {Radius}");
            }
        }

        public static void Draw<T>(List<T> figureCollection) where T : Figure
        {
            foreach (var figure in figureCollection)
            {
                figure.PrintFigureName();
            }
        }
    }
    }
}
