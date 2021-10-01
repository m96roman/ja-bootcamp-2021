using System;

namespace DIvanyshyn_5.Task_4
{
    public class MeestExprees : Delivery<ForeignPackage>
    {
        public override void DeliverPackage(ForeignPackage package)
        {
            base.DeliverPackage(package);
            Console.WriteLine($"SMS from MeestExprees: Delivered package from {package.SenderCountry}");
        }
    }
}
