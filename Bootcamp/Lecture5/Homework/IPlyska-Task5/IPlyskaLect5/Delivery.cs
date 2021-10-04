using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class Delivery<T> where T : Package
    {
      public void DeliverPackage(T package)
      {
            if (package is null)
            {
                throw new ArgumentNullException(nameof(package), "Argument can not be null");
            }

            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} with size = {package.Size} for you.");

            if (package is DomesticPackage domestic)
            {
                Console.WriteLine($"Pop-up notification from NP: You can pick up you package at {domestic.DepartmentId} department.");
            }
            else if(package is ForeignPackage foreign)
            {
                Console.WriteLine($"SMS from MeestExprees: Delivered package from {foreign.SenderCountry}");
            }
      }
    }
}
