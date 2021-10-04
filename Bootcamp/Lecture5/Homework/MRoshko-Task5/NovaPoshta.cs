using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task5
{
    public class NovaPoshta : Delivery<DomesticPackage>
    {
        public override void GetDeliverPackageInfo(DomesticPackage package)
        {
            Console.WriteLine($"Pop-up notification from NP: You can pick up you package at {package.DepartmentId} department.");
        }
    }

}
