using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public abstract class Delivery<T> where T : Package
    {
        public virtual void DeliverPackage(T package)
        {
            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} with size = {package.Size} for you.");
        }
    }
}
