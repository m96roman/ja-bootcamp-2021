using System;

namespace DeliveryProject
{
    public class MeestExpress : Delivery<ForeignPackage>
    {
        public void DeliverPackage(ForeignPackage package)
        {
            base.DeliverPackage(package);
            Console.WriteLine($"SMS from MeestExprees: Delivered package from {package.SenderCountry}");
        }
    }
}
