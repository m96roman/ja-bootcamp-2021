using System;

namespace YaroslavB_Task5
{
    class NovaPoshta : Delivery<DomesticPackage>
    {
        public override void InformRecipient(DomesticPackage package)
        {
            Console.WriteLine($"Pop-up notification from NP: You can pick up you package at {package.DepartmentId} department.");
        }
    }
}

