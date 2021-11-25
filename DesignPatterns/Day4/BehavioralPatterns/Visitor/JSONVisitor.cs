using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class JSONVisitor : IVisitor
    {
        public void VisitDriver(Driver driver)
        {
            Console.WriteLine("FirstName: \" {0} \"; LastName:  \" {1} \"; Date of Birth:  \" {2} \";" +
                              " Number of driver's license:  \" {3} \"; Year of issue: \" {4} \";",
                driver.FirstName, driver.LastName, driver.DateOfBirth, driver.DriveLicenseNumber, driver.Year);
        }

        public void VisitCar(Car car)
        {
            Console.WriteLine("Model: \" {0} \"; Number: \" {1} \"; Color: \" {2} \";" +
                              "Year: \" {3} \"; Brand: \" {4} \";", car.Model, car.Number, car.Color, car.Year, car.Brand);
        }
    }
}
