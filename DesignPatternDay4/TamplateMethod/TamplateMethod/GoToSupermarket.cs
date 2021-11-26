using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod
{
    class GoToSupermarket : DoShopping
    {
        public override void GoOut()
        {
            Console.WriteLine("Go out from office.");
        }
        public override void GoToShop()
        {
            Console.WriteLine("Go to supermarket.");
            Console.WriteLine("Take basket.");
            Console.WriteLine("Walk through departments.");
        }
        public override void Choose()
        {
            Console.WriteLine("Take what you need.");
        }
        public override void Pay()
        {
            Console.WriteLine("Go to cash box.");
            Console.WriteLine("Pay with card.");
        }       
    }
}