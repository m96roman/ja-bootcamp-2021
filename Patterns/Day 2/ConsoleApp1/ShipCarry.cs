using System;

namespace ConsoleApp1
{
    public class ShipCarry : LogicalCompany
    {
        public ShipCarry(string name, string address) : base(name, address) { }

        public override Stone Carry()
        {
            Console.WriteLine($"{Name} was delivered by ship to {Address}");

            return new Stone();
        }
    }
}
