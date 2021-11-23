using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Director
    {
        public ICarComponents carComponents { get; set; }
        public void CreateMinimalProduct()
        {
            carComponents.Engine(1.5);
            carComponents.Engine(15);
            carComponents.heatedSeats(false);
            Console.WriteLine("minimal set" + carComponents.GetModelCar() );
        }

        public void CreatePremiumProduct()
        {
            carComponents.Engine(1.8);
            carComponents.Engine(16);
            carComponents.heatedSeats(false);
            Console.WriteLine("Premium set" + carComponents.GetModelCar());
        }
        public void CreateSuperMegaProduct()
        {
            carComponents.Engine(1.81);
            carComponents.Engine(17);
            carComponents.heatedSeats(true);
            Console.WriteLine("SuperMega set" + carComponents.GetModelCar());
        }
    }
}
