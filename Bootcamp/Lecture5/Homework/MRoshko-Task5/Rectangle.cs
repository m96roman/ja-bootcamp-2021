using System;

namespace MRoshko_Task5
{
    public class Rectangle : Drawable
    {
        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public Rectangle(double firstSide, double secondSide) : base()
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
        }

        public override void PrintArea()
        {
            Console.WriteLine($"Area of {this} is {FirstSide * SecondSide}");
        }
    }
}
