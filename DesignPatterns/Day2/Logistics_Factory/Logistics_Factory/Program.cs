using Goods;
using Logistics_Factory.Logistics;
using System;

namespace Logistics_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            MainLogisticOffice mainLogisticOffice = new MainLogisticOffice();

            mainLogisticOffice.DeliverBySea("Brasil", new Stone { Name = "Stone1" });
            mainLogisticOffice.DeliverBySea("Argentina", new Stone { Name = "Stone2" });

            mainLogisticOffice.DeliverByLand("Barcelona", new Stone { Name = "Stone3" });
            mainLogisticOffice.DeliverByLand("Andalucia", new Stone { Name = "Stone4" });
            mainLogisticOffice.DeliverByLand("Paris", new Stone { Name = "Stone5" });
            mainLogisticOffice.DeliverByLand("Lion", new Stone { Name = "Stone6" });

            mainLogisticOffice.DeliverByAir("Shanhai", new Stone { Name = "Stone7" });
        }
    }
}
