using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            var builder = new Builder("A2");

            director.builder = builder;
            director.BuildPremium();
            Console.WriteLine(builder.GetCar().ListParts());

            var builder2 = new Builder("A1");
            director.builder = builder2;
            director.BuildLuxury();
            Console.WriteLine(builder2.GetCar().ListParts());

            Console.ReadKey();


        }
    }
}
