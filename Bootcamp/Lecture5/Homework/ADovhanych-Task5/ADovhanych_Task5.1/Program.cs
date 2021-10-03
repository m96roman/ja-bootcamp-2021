using System;
using System.Collections.Generic;

namespace ADovhanych_Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> shapes = new List<IDrawable> { new Rectangle(), new Circle(), new Point() };
            Rectangle[] rectangles = new[] { new Rectangle(), new Rectangle() };
            DrawShapes(shapes);
            DrawShapes(rectangles);
        }

        public static void DrawShapes<T>(IEnumerable<T> shapes) where T : IDrawable
        {
            foreach (T shape in shapes)
            {
                shape.DrawShape();
            }
        }
    }
}
