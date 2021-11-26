using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod
{
    class BuyFurniture :DoShopping
    {
        public override void GoOut()
        {
            Console.WriteLine("Go out from home.");
        }
        public override void GoToShop()
        {
            Console.WriteLine("Go to furniture shop.");
        }
        public override void Choose()
        {
            Console.WriteLine("Choose the furniture.");
        }
        public override void Pay()
        {
            Console.WriteLine("Write a check.");
        }
        public override void BringHome()
        {
            Console.WriteLine("Order delivery.");
            Console.WriteLine("Take home.");
        }
    }
}
