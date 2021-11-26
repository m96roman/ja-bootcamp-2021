using System.Collections.Generic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create logical company
            List<LogicalCompany> company = new List<LogicalCompany>();

            // create bagages
            Stone stone1 = new Stone(name: "Marble", address: "New York");
            Stone stone2 = new Stone(name: "Quartzite", address: "Los Angeles");
            Stone stone3 = new Stone(name: "Limestone", address: "San Antonio");
            Stone stone4 = new Stone(name: "Granite", address: "Dallas");
            Stone stone5 = new Stone(name: "Basalts", address: "Sacramento");
            Stone stone6 = new Stone(name: "Onyx", address: "San Francisco");
            Stone stone7 = new Stone(name: "Travertine", address: "El Paso");

            // add applications
            // 2 applications - ship
            // 1 application - plane
            // 4 applications - car

            company.Add(new ShipCarry(stone1));
            company.Add(new ShipCarry(stone2));

            company.Add(new PlaneCarry(stone3));

            company.Add(new CarCarry(stone4));
            company.Add(new CarCarry(stone5));
            company.Add(new CarCarry(stone6));
            company.Add(new CarCarry(stone7));

            // carry all applications
            foreach (var item in company)
            {
                Stone stone = item.Carry();

                Console.WriteLine($"{stone.Name} was delivered by plane to {stone.Address}");
            }
        }
    }
}
