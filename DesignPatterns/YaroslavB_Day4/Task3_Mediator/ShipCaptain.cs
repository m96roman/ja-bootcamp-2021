using System;

namespace Task3_Mediator
{
    public class ShipCaptain
    {
        private IMediator _controlRoom;

        public string ShipName { get; set; }

        public ShipCaptain(IMediator mediator = null)
        {

        }

        public void SetMediator(IMediator mediator)
        {
            _controlRoom = mediator;
        }

        public void SendMessage(string receiver, string message)
        {
            _controlRoom.Notification(this, receiver, message);
        }

        public void ReceiveMessage(string senderName, string message)
        {
            Console.WriteLine($"Ship {ShipName}:" +
                $"\n  received new message from {senderName}:" +
                $"\n  - {message}");
        }
    }
}
