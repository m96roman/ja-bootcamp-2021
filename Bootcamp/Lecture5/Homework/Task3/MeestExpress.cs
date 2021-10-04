using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class MeestExpress : Delivery<ForeignPackage>
    {
        public override void DeliverPackage(ForeignPackage package)
        {
            base.DeliverPackage(package);

            Console.WriteLine($"SMS from MeestExprees: Delivered package from {package.SenderCountry}");
        }
    }
}
