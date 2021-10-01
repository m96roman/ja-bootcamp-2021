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

        /// <summary>
        /// Just for example
        /// Yes We can create - FigureInfo(List<Figure> figures) 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="figures"></param>
        public void FigureInfo<T>(IEnumerable<T> figures) where T: Figure
        {
            if (figures is null || figures.Count() == 0 )
            {
                throw new ArgumentNullException(nameof(figures), "Agument can not be a null or an empty");
            }

            foreach (var item in figures) 
            {  
                item.Draw();
            }
        }

        public void FigureInfo<T>(T figure1, T figure2) where T : Figure
        {
            if (figure1 is null || figure2 is null)
            {
                throw new ArgumentNullException(nameof(figure1), nameof(figure2));
            }

            figure1.Draw();
            figure2.Draw();
        }

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
