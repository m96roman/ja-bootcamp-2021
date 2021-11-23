using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Logistics
    {
        public List<Application> applications = new List<Application>();
        public void PlanDelivery(string adressa)
        {
            
            applications.Add(new Application(adressa, "Stone", GetTransport()));
        }

        public void CompleteApplication()
        {
            foreach( var application in applications)
            {
                Console.WriteLine($"{application.Product} was {application.Transport.Delivery()} to {application.Adress}");

            }
        }
        public abstract ITransport GetTransport();

       
    }
}
