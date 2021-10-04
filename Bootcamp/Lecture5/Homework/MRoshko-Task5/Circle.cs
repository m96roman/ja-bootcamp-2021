using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task5
{
    public class Circle : Drawable
    {
        public double Radius { get; set; }
        public Circle(double r) : base()
        {
            this.Radius = r;
        }

        public override void PrintArea(){
            Console.WriteLine($"Area of {this} is {Radius * 2 * Math.PI}");
        }
    }
}
