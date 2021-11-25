using System;
using ConsoleApp6.Abstracts;

namespace ConsoleApp6.Houses
{
    public class PanelHouse : House
    {
        public override void BuildHouse(string streetName)
        {
            Console.WriteLine($"{Type} house with {FloorAmount} floors built on {streetName} street");
        }
    }
}
