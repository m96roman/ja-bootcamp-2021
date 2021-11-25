using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Observed
{
   public interface IObservable
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObserver();
    }
}
