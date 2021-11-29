using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Gift : Purchase
    {
        public override void GetOut()
        {
            Console.WriteLine("Get out of home");
        }

        public override void GoToThe()
        {
            Console.WriteLine("Go to the mall");
        }

        public override void Pay()
        {
            Console.WriteLine("Pay by card");

        }
    }
}
