using System;

namespace YaroslavB_Task5
{
    class MeestExpress : Delivery<ForeignPackage>
    {
        public override void InformRecipient(ForeignPackage package)
        {
            Console.WriteLine($"SMS from MeestExprees: Delivered package from {package.SenderCountry}");
        }
    }
}


