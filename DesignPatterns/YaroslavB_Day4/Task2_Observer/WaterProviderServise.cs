using System;
using System.Collections.Generic;
using System.Threading;

namespace Task2_Observer
{
    class WaterProviderServise : IObservable
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void AddSubscriber(ISubscriber subscriber)
        {
            bool isSubscriberExists = _subscribers.Contains(subscriber);

            if (!isSubscriberExists)
            {
                _subscribers.Add(subscriber);
            }
        }

        public void NotifyObservers(string context)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(context);
            }
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            bool isListEmpty = _subscribers is null || _subscribers.Count == 0;
            bool isSubscriberExists = _subscribers.Contains(subscriber);

            if (!isListEmpty && isSubscriberExists)
            {
                _subscribers.Remove(subscriber);
            }
        }

        public void CarryOutMaintenance()
        {
            Console.WriteLine("ServiseMessage: Stopped water supply, start maintenance.");
            Thread.Sleep(5000);
            Console.WriteLine("ServiseMessage: Stopped maintenance, restored water supply.");
        }
    }
}
