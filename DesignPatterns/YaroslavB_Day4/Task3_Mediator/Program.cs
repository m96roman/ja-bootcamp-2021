using System;

namespace Task3_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var captainOfKyiv = new ShipCaptain() { ShipName = "Kyiv" };
            var captainOfLviv = new ShipCaptain() { ShipName = "Lviv" };
            var captainOfUzhgorod = new ShipCaptain() { ShipName = "Uzhgorod" };

            var controlRoom = new SeaportControlRoom(captainOfKyiv, captainOfLviv, captainOfUzhgorod);

            captainOfKyiv.SendMessage("Lviv", "Hello, we are near you, port st. Ostrogo");
            Console.WriteLine("\n");
            captainOfLviv.SendMessage("Kyiv", "Clear, we wait for you.");
            Console.WriteLine("\n");
            captainOfKyiv.SendMessage("Ivan from office", $"We are going to meet the \'Lviv\', will be on base tomorrow");
            Console.WriteLine("\n");
            captainOfKyiv.SendMessage("ControlRoom", $"We are going to meet the \'Lviv\', will be on base tomorrow");

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
