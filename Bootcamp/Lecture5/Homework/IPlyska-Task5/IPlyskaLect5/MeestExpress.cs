using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class MeestExpress : Delivery<DomesticPackage>
    {
        public void DeliverPackage(DomesticPackage package)
        {
            base.DeliverPackage(package);
            Console.WriteLine($"Pop-up notification from NP: You can pick up you package at {package.DepartmentId} department.");
        }
    }
}
