using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Logistics logisticsSea = new SeaLogistics();
            var ship=logisticsSea.GetTransport();
            logisticsSea.PlanDelivery("Pyshkina 6",ship);
            logisticsSea.PlanDelivery("Pyshkina 10",ship);

            Logistics logisticsTruck = new TruckLogistics();
            var truck = logisticsTruck.GetTransport();
            logisticsTruck.PlanDelivery("Pyshkina 6",truck);
            logisticsTruck.PlanDelivery("Pyshkina 8",truck);
            logisticsTruck.PlanDelivery("Pyshkina 10",truck);
            logisticsTruck.PlanDelivery("Pyshkina 12",truck);

            Logistics logisticsAirPlane= new AirplaneLogistics();
            var aitPlane = logisticsAirPlane.GetTransport();
            logisticsAirPlane.PlanDelivery("Pyshkina 6",aitPlane);

            logisticsSea.CompleteApplication();
            logisticsTruck.CompleteApplication();
            logisticsAirPlane.CompleteApplication();

            Console.ReadKey();
        }
    }
}
