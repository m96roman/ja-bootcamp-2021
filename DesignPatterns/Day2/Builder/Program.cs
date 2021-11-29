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
            var distributor = new Distributor();

            CarBuilder builder = new BasicCarBuilder();

            Car basicCar = distributor.Make(builder,"A1");
            
            Console.WriteLine(basicCar.ListParts());

            builder = new PremiumCarBuilder();

            Car premiumCar = distributor.Make(builder, "A2");

            Console.WriteLine(premiumCar.ListParts());

            Console.ReadKey();
        }
    }
}
