using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"{this.GetType().Name} was drawn! His radius is {this.Radius}");
        }
    }
}
