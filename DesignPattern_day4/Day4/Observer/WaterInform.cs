using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class WaterInform:IWaterInform
    {
        public bool State { get; set; } = true;
        private List<IWaterService> _client = new List<IWaterService>();

        public void Add(IWaterService waterService)
        {
            Console.WriteLine("Client attached to notify");
            _client.Add(waterService);
        }

        public void Notify()
        {
            Console.WriteLine("Clients notifying");
            foreach (var item in _client)
            {
                item.Update(this);
            }
        }
        public void RandomOffWater()
        {
           
            Random random = new Random();
            int value = random.Next(0, 2);         
            string waterOnOrOff = "water will be turned off";
            if (value==0)
            {
                this.State = false;
                Console.WriteLine();
            }
            else
            {
                this.State = true;
                waterOnOrOff = "water will be included";
            }
            Console.WriteLine(waterOnOrOff);
            this.Notify();
        }
    }
}
