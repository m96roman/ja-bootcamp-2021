using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class ForeignDelivery : Delivery<ForeignPackage>
    {
        public override string GetSecurityInfo(ForeignPackage package)
        {
            return $"SMS from MeestExprees: Delivered package from {package.SenderCountry}";
        }
    }
}
