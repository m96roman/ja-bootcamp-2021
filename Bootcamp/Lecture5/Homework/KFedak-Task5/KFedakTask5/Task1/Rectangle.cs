using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    class Rectangle : Shape
    {
        public double[] point = new double[4];

        public Rectangle(double[] point)
        {
            this.point = point;
        }
    }
}
