using System;

namespace YaroslavB_Task5
{
    abstract class Delivery<T> where T : Package
    {
        public abstract void InformRecipient(T package);

        public void DeliverPackage(T package)
        {
            Console.WriteLine($"Hi, {package.Recipient}. We have {package.Title} " +
                                $"with size = {package.Size} for you.");
        }
    }
}

