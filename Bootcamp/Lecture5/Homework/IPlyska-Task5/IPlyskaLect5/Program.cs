using System;
using System.Collections.Generic;

namespace IPlyskaLect5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1

            Figure figure = new Figure();

            List<Figure> container = new List<Figure>() 
            {
                new Point(20,30),
                new Rectangle(5, 6),
                new Circle(10)
            };

            figure.FigureInfo<Figure>(container);
            figure.FigureInfo<Figure>(new Point(300, 700), new Circle(789));

            //
        }
    }
}
