using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class Figure
    {
        public string Name { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine($"Figure {this.GetType().Name} was drawn");
        }
    }

    public class Point : Figure
    {
        private readonly int x;
        private readonly int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Draw()
        {
            Console.WriteLine($"Point {this.GetType().Name} was drawn with coordinates {x}, {y}");
        }
    }
    public class Rectangle : Figure
    {
        private readonly int a;
        private readonly int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle {this.GetType().Name} was drawn with sides {a}, {b}");
        }

    }
    public class Circle : Figure
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Circle {this.GetType().Name} was drawn with radius {radius}");
        }
    }

}
