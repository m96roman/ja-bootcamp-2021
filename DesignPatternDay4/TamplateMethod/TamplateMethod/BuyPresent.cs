using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod
{
    class BuyPresent : DoShopping
    {
        public override void GoOut()
        {
            Console.WriteLine("Go out from home.");
        }
        public override void GoToShop()
        {
            Console.WriteLine("Go to mall.");
        }
        public override void Choose()
        {
            Console.WriteLine("Find somthing for present.");
        }
        public override void Pay()
        {
            Console.WriteLine("Pay with card.");
        }
        
    }
}
