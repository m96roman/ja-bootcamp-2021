using System;

namespace DeliveryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NovaPoshta novaPoshta = new NovaPoshta();
            MeestExpress meestExpress = new MeestExpress();

            ForeignPackage packageME = new ForeignPackage
            { 
                Size = 20, 
                Title = "Clothes", 
                Recipient = "Ivanov", 
                SenderCountry = "USA"
            };

            DomesticPackage packageNP = new DomesticPackage
            {
                Size = 15,
                Title = "Cosmetics",
                Recipient = "Doe",
                DepartmentId = 22
            };

            novaPoshta.DeliverPackage(packageNP);
            meestExpress.DeliverPackage(packageME);
        }
    }
}
