using System;

namespace YaroslavB_Task5
{
    class Delivery<T> where T : Package
    {
        protected Package _package;

        public Delivery(Package package)
        {
            _package = package;

        }

        public void DeliverPackage()
        {
            Console.WriteLine($"Hi, {_package.Recipient}. We have {_package.Title} " +
                                $"with size = {_package.Size} for you.");

            if (_package is ForeignPackage fPack)
            {
                new MeestExpress().InformRecipient(fPack.SenderCountry);
            }

            if (_package is DomesticPackage dPack)
            {
                new NovaPoshta().InformRecipient(dPack.DepartmentId);
            }
        }
    }
}

