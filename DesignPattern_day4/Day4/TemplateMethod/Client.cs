using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Client
    {
        public void Simulate(Shop shop)
        {
            shop.SimulateShopping();
        }
    }
}
