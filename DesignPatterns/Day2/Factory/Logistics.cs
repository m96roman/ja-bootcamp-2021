using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal abstract class Logistics
    {
        public List<Application> Applications = new List<Application>();
        public void PlanDelivery(string address)
        {
            
            Applications.Add(new Application(address, "Stone", GetTransport()));
        }

        public void CompleteApplication()
        {
            foreach( var application in Applications)
            {
                Console.WriteLine($"{application.Product} was {application.Transport.Delivery()} to {application.Address}");

            }
        }
        public abstract ITransport GetTransport();

       
    }
}
