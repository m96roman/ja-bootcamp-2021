using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_task5._4
{
    class Delivery<T> where T : Package
    {
        public void DeliverPackage(Package package)
        {
            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} with size = {package.Size} for you.");
        }
    }
}
