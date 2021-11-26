using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Serializers
{
    class NotJsonSerializerVisitor : IVisitor
    {
        public void VCar(Car car)
        {
            Console.WriteLine($"{nameof(car)}");
            ShowInfo(new List<object>()
            {
                car.Brand,
                car.Model,
                car.Date,
                car.Color,
                car.SerialNumber
            });
        }

        public void VDriver(Driver driver)
        {
            Console.WriteLine($"{nameof(driver)}");
            ShowInfo(new List<object>()
            {
                driver.Name,
                driver.Surname,
                driver.DateOfBirthday,
                driver.DriverLicenseNumber,
                driver.DateIssueDriverLicense
            });
        }

        private void ShowInfo(List<object> list)
        {
            foreach (var iteam in list)
            {
                if (iteam.GetType() == typeof(Date))
                {
                    var date = (Date)iteam;
                    Console.Write($"{nameof(date)}:{date.GetDate()};");
                }
                else 
                {
                    Console.Write($"{nameof(iteam)}:{iteam};");
                }
            }
            Console.WriteLine();
        }
    }
}
