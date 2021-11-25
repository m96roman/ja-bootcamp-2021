using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
  internal  class SimpleVisitor:IVisitor
    {
        public void VisitDriver(Driver driver)
        {
            string result = $"FirstName: {driver.FirstName}; LastName: {driver.LastName}; Date of Birth: {driver.DateOfBirth};" +
                            $" Number of driver's license:{driver.DriveLicenseNumber}; Year of issue: {driver.Year};";
            Console.WriteLine(result);
        }

        public void VisitCar(Car car)
        {
            string result = $"Model: {car.Model}; Number: {car.Number}; Color: {car.Color};" +
                            $"Year: {car.Year}; Brand: {car.Brand};";
            Console.WriteLine(result);
        }
    }
}
