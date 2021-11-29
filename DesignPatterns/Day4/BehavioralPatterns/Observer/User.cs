using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
   internal class User:IObserver
    {
        public string Name { get; set; }

        private IObservable waterWay;

        public User(string name,IObservable waterWay)
        {
            Name = name;
            this.waterWay = waterWay;
            waterWay.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            WaterWayInfo waterWayInfo = (WaterWayInfo) ob;
            Console.WriteLine($"Message to {Name}:\n{waterWayInfo.Message}");
        }

        public void ActionAfterNotification()
        {
             Console.WriteLine($"{Name}: Okey,thanks for inform us");

        }
    }
}
