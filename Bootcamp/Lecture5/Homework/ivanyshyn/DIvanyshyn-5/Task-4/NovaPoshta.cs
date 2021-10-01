using System;

namespace DIvanyshyn_5.Task_4
{
    public class NovaPoshta : Delivery<DomesticPackage>
    {
        public override void DeliverPackage(DomesticPackage package)
        {
            base.DeliverPackage(package);
            Console.WriteLine($"Pop-up notification from NP: You can pick up you package at {package.DepartmetnId}");
        }
    }
}
