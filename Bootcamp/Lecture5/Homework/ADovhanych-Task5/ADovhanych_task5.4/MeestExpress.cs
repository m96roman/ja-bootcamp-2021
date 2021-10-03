using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_task5._4
{
    class MeestExpress : Delivery<ForeignPackage>
    {
        public void DeliverPackage(ForeignPackage package)
        {
            base.DeliverPackage(package);
            Console.WriteLine($"SMS from MeestExprees: Delivered package from {package.SenderCountry}");
        }
    }
}
