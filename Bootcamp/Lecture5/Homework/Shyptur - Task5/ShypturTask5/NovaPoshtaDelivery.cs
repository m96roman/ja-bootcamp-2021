using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public class NovaPoshtaDelivery : Delivery<DomesticPackage>
    {
        protected override string MessageFromDelivery(DomesticPackage domestic)
        {
            string msg = $"Pop-up notification from NP: You can pick up you package at {domestic.DepartmentId} department.";
            return msg;
        }
    }
}
