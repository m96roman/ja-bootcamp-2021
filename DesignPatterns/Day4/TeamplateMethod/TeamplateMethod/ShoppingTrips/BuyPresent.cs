using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamplateMethod.ShoppingTrips
{
    class BuyPresent : ShoppingTrip
    {
        protected override void RequiredGoOut()
        {
            Console.WriteLine("Get out of the house");
        }

        protected override void RequiredGoToThe()
        {
            Console.WriteLine("Go to the shopping center");
        }

        protected override void RequiredPayBuy()
        {
            Console.WriteLine("Pay buy credit cart ");
        }
    }
}
