using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Observed
{
    class Vodokanal : IObservable
    {

        VodokanalInfo info;
        List<IObserver> observers;

        public Vodokanal()
        {
            observers = new List<IObserver>();
            info = new VodokanalInfo();
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(info);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

     
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
