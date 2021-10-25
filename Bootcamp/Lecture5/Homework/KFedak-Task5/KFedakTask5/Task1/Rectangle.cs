using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    class Rectangle : IShape
    {
        public double[] point = new double[4];

        public Rectangle(double[] point)
        {
            this.point = point;
        }

        public void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} was drawn! His points are:\n{string.Join(Environment.NewLine, point)}");
        }
    }
}
