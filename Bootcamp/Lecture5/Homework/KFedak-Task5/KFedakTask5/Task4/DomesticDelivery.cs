using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public class DomesticDelivery : Delivery<DomesticPackage>
    {
        public override string GetSecurityInfo(DomesticPackage package)
        {
            return $"Pop-up notification from NP: You can pick up you package at {package.DepartmentId} department.";
        }
    }
}
