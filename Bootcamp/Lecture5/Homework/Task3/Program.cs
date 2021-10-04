using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var packages = new Package[] {
                new ForeignPackage(20, "Chair", "Vasyl", "USA"),
                new ForeignPackage(8, "Boottle", "Andriy", "Poland"),
                new DomesticPackage(7, "Laptop", "Taras", 43),
                new DomesticPackage(34, "TV", "Oleh", 23)
            };

            Delivery<ForeignPackage> delivery1 = new MeestExpress();
            Delivery<DomesticPackage> delivery2 = new NovaPoshta();

            foreach (var package in packages)
            {
                if (package is ForeignPackage foreignPackage)
                {
                    delivery1.DeliverPackage(foreignPackage);
                }
                else if (package is DomesticPackage domesticPackage)
                {
                    delivery2.DeliverPackage(domesticPackage);
                }
            }
        }
    }
}
