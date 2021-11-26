using System;
using Visitor.Serializers;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonSerializer = new JsonSerializerVisitor();
            var notJsonSerializer = new NotJsonSerializerVisitor();

            var car = new Car()
            {
                Brand = "Audi",
                Model = "Q7",
                Color = "Gray",
                Date = new Date() { Day = 04, Mounth = 8, Year = 2020 },
                SerialNumber = 00020402832,
            };

            var driver = new Driver()
            {
                Name = "Martin",
                Surname = "Roshko",
                DateOfBirthday = new Date() { Day = 15, Mounth = 12, Year = 2000 },
                DriverLicenseNumber = 328193288211,
                DateIssueDriverLicense = new Date() { Day = 22, Mounth = 02, Year = 2018 },
            };

            car.InfoSerialize(jsonSerializer);
            car.InfoSerialize(notJsonSerializer);

            driver.InfoSerialize(jsonSerializer);
            driver.InfoSerialize(notJsonSerializer);

        }
    }
}
