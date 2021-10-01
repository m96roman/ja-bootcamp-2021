namespace MRoshko_Task3
{
    using System;


    internal class Program
    {
        internal static void Main(string[] args)
        {
            Task2();

            //Task1();
        }

        static public void Task2()
        {
            //Task2 task2 = new Task2(1);

            Task2 task2 = new Task2(2);

        }

        static public void Task1()
        {
            Car[] Garage = new Car[] { new Ferrari(4), new Mercedes(4, "Black"), new Lada() };

            foreach (Car car in Garage)
            {
                car.Price = "1 000 000" + "$";
            }

            Garage[0].Colour = "Red";

            Garage[0].PrintInfo();
        }

        internal abstract class Headlights
        {
            public abstract void XenonHeadlights();
        }

        internal class Car
        {
            protected int wheels;

            public string Colour { get; set; }

            public string Price { get; set; }

            public virtual void Sell(string price)
            {
                Price = price;
                Console.WriteLine($"Your car was sell");
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Wheels : {wheels}\nColor : {Colour}\nPrice : {Price}");
            }
        }

        internal class Ferrari : Car
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

        internal class Mercedes : Car
        {
            public Mercedes(int wheels, string colour) : base()
            {
                this.wheels = wheels;
                this.Colour = colour;
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
