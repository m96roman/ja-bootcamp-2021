using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public class MeestExpressDelivery : Delivery<ForeignPackage>
    {
        protected override string MessageFromDelivery(ForeignPackage foreign)
        {
            string msg = $"SMS from MeestExprees: Delivered package from { foreign.SenderCountry}";
            return msg;
        }
    }
}
