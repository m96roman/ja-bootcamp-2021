using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create logical company
            List<LogicalCompany> company = new List<LogicalCompany>();

            // add applications
            // 2 applications - ship
            // 1 application - plane
            // 4 applications - car
            company.Add(new ShipCarry(name: "Marble", address: "New York"));
            company.Add(new ShipCarry(name: "Quartzite", address: "Los Angeles"));
            company.Add(new PlaneCarry(name: "Limestone", address: "San Antonio"));

            company.Add(new CarCarry(name: "Granite", address: "Dallas"));
            company.Add(new CarCarry(name: "Basalts", address: "Sacramento"));
            company.Add(new CarCarry(name: "Onyx", address: "San Francisco"));
            company.Add(new CarCarry(name: "Travertine", address: "El Paso"));

            // carry all applications
            foreach (var item in company)
            {
                 Stone stone = item.Carry();
            }            
        }
    }
}
