using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
   public class ConcreteBuilderA1: AbstractBuilder 
    {
        Product product = new ProductA1();

        public override void BuildDiskDiameter(int d)
        {
            product.Add(@$"Disk's diameter id: {d}");
           Console.WriteLine(@$"Disk's diameter id: {d}");
        }

        public override void BuildEngine(double power)
        {
            product.Add($@"engine is {power}");
            Console.WriteLine($@"engine is {power}");
        }

        public override void BuildHeatedSeets(string boolean)
        {
           product.Add(@$"Heated seats: {boolean}");
            Console.WriteLine(@$"Heated seats: {boolean}");
        }

        public override string GetResult( )
        {
            return "Auto A1";
        }
    }
}
