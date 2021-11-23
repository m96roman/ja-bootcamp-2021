using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics logisticsSea = new SeaLogistics();
            logisticsSea.PlanDelivery("Pyshkina 6");
            logisticsSea.PlanDelivery("Pyshkina 10");

            Logistics logisticsTruck = new TruckLogistics();
            logisticsTruck.PlanDelivery("Pyshkina 6");
            logisticsTruck.PlanDelivery("Pyshkina 8");
            logisticsTruck.PlanDelivery("Pyshkina 10");
            logisticsTruck.PlanDelivery("Pyshkina 12");

            Logistics logisticsAirPlane= new AirplaneLogistics();
            logisticsAirPlane.PlanDelivery("Pyshkina 6");

            logisticsSea.CompleteApplication();
            logisticsTruck.CompleteApplication();
            logisticsAirPlane.CompleteApplication();

            Console.ReadKey();
        }
    }
}
