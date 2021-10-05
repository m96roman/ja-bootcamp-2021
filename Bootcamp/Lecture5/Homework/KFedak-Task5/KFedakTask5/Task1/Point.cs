using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class Point : IShape
    {
        public double PointX { get; set; }
        public double PointY { get; set; }

        public Point(double x, double y)
        {
            PointX = x;
            PointY = y;
        }

        public void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} was drawn! X:{this.PointX} Y:{this.PointY}");
        }
    }
}
