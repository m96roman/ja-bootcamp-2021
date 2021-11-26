using System;
using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Serializers
{
    public class SecondFormatSerializer : IVisitor
    {
        public void VisitCar(Car car)
        {
            string result = "{" + $"Model:\"{car.Model}\"" + "};";
            result += "{" + $" Number:\"{car.Number}\"" + "};";
            result += "{" + $" Color:\"{car.Color}\"" + "};";
            result += "{" + $" Year:\"{car.Year}\"" + "};";

            Console.WriteLine(result);
        }

        public void VisitDriver(Driver driver)
        {
            string result = "{" + $"Name:\"{driver.Name}\"" + "};";
            result += "{" + $"Surname:\"{driver.Surname}\"" + "};";
            result += "{" + $"Birthday:\"{driver.Birthday}\"" + "};";
            result += "{" + $"NumberDrivingLicense:\"{driver.NumberDrivingLicense}\"" + "};";

            Console.WriteLine(result);
        }
    }
}
