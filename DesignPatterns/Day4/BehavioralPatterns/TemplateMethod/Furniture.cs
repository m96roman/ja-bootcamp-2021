using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Furniture : Purchase
    {
        public override void GetOut()
        {
            Console.WriteLine("Get out of home");
        }

        public override void GoToThe()
        {
            Console.WriteLine("Go to the store");
        }

        public override void Pay()
        {
            Console.WriteLine("Write a check");
        }

        public override void OrderDeliveryService()
        {
            Console.WriteLine("Order delivery service");
        }
    }
}
