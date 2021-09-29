namespace MRoshko_Task3
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Cars[] Garage = new Cars[] { new Ferrari(4), new Mercedes(4, "Black"), new Lada() };

            foreach (Cars car in Garage)
            {
                car.price = "1 000 000" + "$";
            }

            Garage[0].colour = "Red";
            Garage[0].PrintInfo();
        }

        internal abstract class Headlights
        {
            public abstract void XenonHeadlights();
        }

        internal class Cars
        {
            protected int wheels;

            public string colour { get; set; }

            public string price { get; set; }

            public virtual void Sell(string price)
            {
                Console.WriteLine($"Your car was sell");
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Wheels : {wheels}\nColor : {colour}\nPrice : {price}");
            }
        }

        internal class Ferrari : Cars
        {
            public Ferrari(int wheels)
            {
                this.wheels = wheels;
            }

            public override void Sell(string price)
            {
                Console.WriteLine($"I want sell my car for {price}");
            }
        }

        internal class Mercedes : Cars
        {
            public Mercedes(int wheels, string colour) : base()
            {
                this.wheels = wheels;
                this.colour = colour;
            }

            public override void Sell(string price)
            {
                Console.WriteLine($"I want sell my car for {price}");
            }
        }

        internal class Lada : Ferrari
        {
            private string rating;

            public Lada() : base(4)
            {
                rating = "*****";
            }

            public void Benefits()
            {
                Console.WriteLine($"Just a cool car)\nRating is {rating}");
            }
        }
    }
}
