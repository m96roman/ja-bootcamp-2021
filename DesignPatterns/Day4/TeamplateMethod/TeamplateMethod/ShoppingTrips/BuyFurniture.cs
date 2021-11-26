using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamplateMethod.ShoppingTrips
{
    class BuyFurniture : ShoppingTrip
    {
        protected override void RequiredGoOut()
        {
            Console.WriteLine("Get out of the house");
        }

        protected override void RequiredGoToThe()
        {
            Console.WriteLine("Go to the store");
        }

        protected override void RequiredPayBuy()
        {
            Console.WriteLine("Write a bank check");
        }

        protected override void HookOrderDeliveryService() 
        {
            Console.WriteLine("Order delivery service");
        }
    }
}
