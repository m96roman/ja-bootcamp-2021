using System;

namespace DeliveryProject
{
    public class NovaPoshta : Delivery<DomesticPackage>
    {
        public void DeliverPackage(DomesticPackage package)
        {
            base.DeliverPackage(package);
            Console.WriteLine($"Pop-up notification from NP: You can pick up you package at {package.DepartmentId} department.");
        }
    }
}
