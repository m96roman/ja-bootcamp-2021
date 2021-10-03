using System;

namespace ADovhanych_task5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var package = new DomesticPackage { Size = 2, DepartmentId = 3, Recipient = "dog", Title = "Pedigree" };
            var foreignPackage = new ForeignPackage { Size = 2, SenderCountry = "Ukraine", Recipient = "cat", Title = "Whiskas" };
            var delivery = new NovaPoshta();
            var foreignDel = new MeestExpress();

            delivery.DeliverPackage(package);
            foreignDel.DeliverPackage(foreignPackage);
        }
    }
}
