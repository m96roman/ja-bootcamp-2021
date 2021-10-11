using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var domesticPackage1 = new DomesticPackage(7, "Laptop", "Taras", 43);
            var domesticPackage2 = new DomesticPackage(7, "Laptop", "Taras", 43);
            var foreignPackage1 = new ForeignPackage(20, "Chair", "Vasyl", "USA");
            var foreignPackage2 = new ForeignPackage(8, "Boottle", "Andriy", "Poland");

            Delivery<ForeignPackage> delivery1 = new MeestExpress();
            Delivery<DomesticPackage> delivery2 = new NovaPoshta();

            delivery1.DeliverPackage(foreignPackage1);
            delivery1.DeliverPackage(foreignPackage2);
            delivery2.DeliverPackage(domesticPackage1);
            delivery2.DeliverPackage(domesticPackage2);
        }
    }
}
