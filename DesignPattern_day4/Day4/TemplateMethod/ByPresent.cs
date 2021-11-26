using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ByPresent : Shop
    {
        protected override void ExitFromYourPlace()
        {
            Console.WriteLine("get out from home");
        }

        protected override void GoToShop()
        {
            Console.WriteLine("Go to shopping centre");
        }
        protected override void PayByCard()
        {
            Console.WriteLine("pay by card MasterCard");
        }
    }
}
