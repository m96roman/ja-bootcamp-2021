using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public abstract class Delivery<T> where T : Package
    {
        public void DeliverPackage(T package)
        {
            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} with size = {package.Size} for you.");
            Console.WriteLine(MessageFromDelivery(package));
        }
        protected abstract string MessageFromDelivery(T package);
    }
}
