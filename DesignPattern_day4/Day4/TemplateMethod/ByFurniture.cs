using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ByFurniture : Shop
    {
        protected override void ExitFromYourPlace()
        {
            Console.WriteLine("Go from home");
        }

        protected override void GoToShop()
        {
            Console.WriteLine("Go to shop");
        }
        protected override void WriteReceipt()
        {
            Console.WriteLine("Write Receipt");
        }
        protected override void OrderDeliveryService()
        {
            Console.WriteLine("Order Delivery Service to home");
        }
    }
}
