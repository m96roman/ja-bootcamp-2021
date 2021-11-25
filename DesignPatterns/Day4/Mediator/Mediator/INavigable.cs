namespace Mediator
{
    public interface INavigable
    {
        string Name { get; set; }

        void SetMediator(IDispatcher dispetcher);
        void Maneuver(string message);
    }
}