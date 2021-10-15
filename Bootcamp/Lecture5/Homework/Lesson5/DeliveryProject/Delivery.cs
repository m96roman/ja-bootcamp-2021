using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProject
{
    public class Delivery<T> where T : Package
    {
        public void DeliverPackage(T package)
        {
            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} with size = {package.Size} for you.");
        }
    }
}
