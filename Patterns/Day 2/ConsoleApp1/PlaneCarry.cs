using System;

namespace ConsoleApp1
{
    public class PlaneCarry : LogicalCompany
    {
        public PlaneCarry(string name, string address) : base(name, address) { }

        public override Stone Carry()
        {
            Console.WriteLine($"{Name} was delivered by plane to {Address}");

            return new Stone();
        }
    }
}
