using System.Collections.Generic;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    public class Vodokanal : IObservable
    {
        protected List<IObserver> observers;

        public Vodokanal()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var o in observers)
            {
                o.Update();
            }
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void SubscribeObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void BlockTheWater()
        {
            NotifyObservers();
        }
    }
}
