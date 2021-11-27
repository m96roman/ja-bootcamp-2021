namespace Task3_Mediator
{
    public interface IMediator
    {
        void Notification(ShipCaptain sender, string receiver, string message);
    }
}
