using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task5
{
    abstract class Delivery<T> where T : Package
    {
        public void DeliverPackage(T info)
        {
            var packageInfo = GetPackageInfo(info);

            Console.WriteLine($"Hi, {info.Recepient}. We have {info.Title} with size = {info.Size} for you.");
            Console.WriteLine(packageInfo);
        }
        protected abstract string GetPackageInfo(T info);
    }
}
