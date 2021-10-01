using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class Point : Shape
    {
        public double PointX { get; set; }
        public double PointY { get; set; }

        public Point(double x,double y)
        {
            PointX = x;
            PointY = y;
        }
    }
}
