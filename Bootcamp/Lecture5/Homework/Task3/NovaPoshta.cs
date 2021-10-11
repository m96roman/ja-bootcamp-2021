using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class NovaPoshta : Delivery<DomesticPackage>
    {
        public override void DeliverPackage(DomesticPackage package)
        {
            base.DeliverPackage(package);

            Console.WriteLine($"Pop-up notification from NP: You can pick up you package at {package.DepartmentId} department.");
        }
    }
}
