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
      }
    }
}
