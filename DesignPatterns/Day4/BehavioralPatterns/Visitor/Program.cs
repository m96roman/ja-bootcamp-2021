using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver= new Driver(){FirstName = "Vasyl", LastName = "Popovuch", DateOfBirth = "10/02/1995", DriveLicenseNumber = 345678342, Year = 2015};
            var car = new Car() {Model = "Q50", Brand = "Infinity", Color = "Grey", Year = 2015, Number = 123457};
           
            Console.WriteLine("Car");
            car.Show(new SimpleVisitor());
            car.Show(new JSONVisitor());

            Console.WriteLine();

            Console.WriteLine("Driver");
            driver.Show(new SimpleVisitor());
            driver.Show(new JSONVisitor());


        }
    }
}
