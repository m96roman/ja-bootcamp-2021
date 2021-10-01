using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    public abstract class Delivery<T> where T : Package
    {
        public string Name { get; set; }
        public abstract string GetSecurityInfo(T package);
        public void DeliverPackage(T package)
        {
            var secretInfo = GetSecurityInfo(package);

            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} with size = {package.Size} for you.\n{secretInfo}");
        }
    }
}
