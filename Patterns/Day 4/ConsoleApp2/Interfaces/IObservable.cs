namespace ConsoleApp2.Interfaces
{
    public interface IObservable
    {
        void SubscribeObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
