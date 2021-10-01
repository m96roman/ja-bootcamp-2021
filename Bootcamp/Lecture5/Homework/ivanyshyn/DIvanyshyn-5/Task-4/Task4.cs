using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_5.Task_4
{
    internal class Task4
    {
        public static void Execute()
        {
            Package[] packages = new Package[] {
                new ForeignPackage(123, "123", "123", "123"),
                new ForeignPackage(222, "222", "222", "222"),
                new DomesticPackage(111,"111","111","123-123-123-HDD"),
                new DomesticPackage(123,"123","123","123-123-123-123")
            };

            Delivery<ForeignPackage> delivery1 = new MeestExprees();
            Delivery<DomesticPackage> delivery2 = new NovaPoshta();
            foreach (var item in packages)
            {
                if (item is ForeignPackage fp)
                {
                    delivery1.DeliverPackage(fp);
                }
                else if (item is DomesticPackage ds)
                {
                    delivery2.DeliverPackage(ds);
                }

                System.Console.WriteLine(new string('-', 20));
            }
        }
    }
}
