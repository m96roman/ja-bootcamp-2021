using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport plane = new Plane("Plane");
             plane.Send();
            Console.WriteLine(@$"by {plane.Name}");
            Console.WriteLine("------------------");

            Transport car = new Car("Car");
            car.Send();
            Console.WriteLine(@$"by {car.Name}");
            Console.WriteLine("------------------");

            Transport ship = new Ship("Ship");
            ship.Send();
            Console.WriteLine(@$"by {ship.Name}");
            Console.WriteLine("------------------");

            Console.ReadLine();
        }
    }
}
