using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task5
{
    public class MeestExpress : Delivery<ForeignPackage>
    {
        public override void GetDeliverPackageInfo(ForeignPackage package)
        {
            Console.WriteLine($"SMS from MeestExprees: Delivered package from {package.SenderCountry}");
        }
       
    }
}
