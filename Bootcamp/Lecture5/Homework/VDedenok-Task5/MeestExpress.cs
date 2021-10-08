using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task5
{

   class MeestExpress : Delivery<ForeignPackage>
    {
        protected override string GetPackageInfo(ForeignPackage info)
        {
            return ($"SMS from MeestExprees: Delivered package from {info.SenderCountry}.");
        }
    }
}
