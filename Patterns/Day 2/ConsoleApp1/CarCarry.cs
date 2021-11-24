using System;

namespace ConsoleApp1
{
    public class CarCarry : LogicalCompany
    {
        public CarCarry(string name, string address) : base(name, address) { }

        public override Stone Carry()
        {
            Console.WriteLine($"{Name} was delivered by car to {Address}");

            return new Stone();
        }
    }
}
