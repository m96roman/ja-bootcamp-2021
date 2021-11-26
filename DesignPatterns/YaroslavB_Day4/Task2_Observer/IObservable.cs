namespace Task2_Observer
{
    public interface IObservable
    {
        void AddSubscriber(ISubscriber subscriber);
        void RemoveSubscriber(ISubscriber subscriber);
        void NotifyObservers(string context);
    }
}
