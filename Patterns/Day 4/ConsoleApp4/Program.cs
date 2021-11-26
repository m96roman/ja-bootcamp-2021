using System;
using ConsoleApp4.Serializers;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Visitor */

            var objects = new Objects();

            objects.Add(new Car { Number = "BC 3476 MH", Color = "Gray", Model = "Roadster", Year = 2021 });
            objects.Add(new Car { Number = "BC 6743 KO", Color = "Black", Model = "Supercar", Year = 2020 });

            objects.Add(new Driver { Name = "Driver1Name", Birthday = "5.8.1987", NumberDrivingLicense = 5636765324, Surname = "Driver1Surname" });
            objects.Add(new Driver { Name = "Driver2Name", Birthday = "26.12.1993", NumberDrivingLicense = 7868678678, Surname = "Driver2Surname" });

            objects.Accept(new FirstFormatSerializer());
            Console.WriteLine();
            objects.Accept(new SecondFormatSerializer());
        }
    }
}
