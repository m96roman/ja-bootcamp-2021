using System;
using System.Collections.Generic;

namespace IPlyskaLect5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1

            //Task1 figure = new Task1();

            //List<Figure> container = new List<Figure>() 
            //{
            //    new Point(20,30),
            //    new Rectangle(5, 6),
            //    new Circle(10)
            //};

            //figure.FigureInfo<Figure>(container);
            //figure.FigureInfo<Figure>(new Point(300, 700), new Circle(789));

            //
            //Task2
            Task2 task2 = new Task2();
            task2.Run();
            //
            //Task3

            var result1 = new DataReader().GetCityNames();
            var result2 = new DataReader().GetMagicNumber();
            Console.WriteLine($"status for {nameof(result1)} is {result1.IsSucceded} and values");
            foreach (var item in result1.Value)
            {
                Console.WriteLine($"{item}");
            }
            if (!result2.IsSucceded)
            {
                Console.WriteLine("Can not to retrieve data");
            }
            else
            {
                Console.WriteLine($"status for {nameof(result2)} is {result1.IsSucceded} and values {result2.Value}");
            }

        }
    }
}
