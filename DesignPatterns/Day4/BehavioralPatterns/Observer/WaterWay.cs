using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class WaterWay :IObservable
    {
        WaterWayInfo waterWayInfo; 

        List<IObserver> observers;

        public WaterWay()
        {
            observers = new List<IObserver>();
            waterWayInfo = new WaterWayInfo();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(waterWayInfo);
            }
        }

        public void Attention()
        {
            waterWayInfo.Message = "Sorry!But you do not have anymore a water";
            NotifyObservers();
        }
    }
}
