using System;

namespace Task3_Mediator
{
    class SeaportControlRoom : IMediator
    {
        private ShipCaptain _captainKyiv;
        private ShipCaptain _captainLviv;
        private ShipCaptain _captainUzhgorod;

        public SeaportControlRoom(ShipCaptain captainKyiv, ShipCaptain captainLviv, ShipCaptain captainUzhgorod)
        {
            captainKyiv.SetMediator(this);
            captainLviv.SetMediator(this);
            captainUzhgorod.SetMediator(this);
            _captainKyiv = captainKyiv;
            _captainLviv = captainLviv;
            _captainUzhgorod = captainUzhgorod;
        }

        public void Notification(ShipCaptain sender, string receiver, string message)
        {
            Console.WriteLine($"SeaportControlRoom: received message from " +
                $"{sender.ShipName}, for {receiver}" +
                $"\n - \'{message}\'");

            LogComunication(sender, receiver, message);

            ProcessMessage(sender, receiver, message);

            if (sender.ShipName == "Kyiv")
            {
                //react
            }
            if (sender.ShipName == "Lviv")
            {
                //react
            }
            if (sender.ShipName == "Uzhgorod")
            {
                //react
            }
        }


        private void ProcessMessage(ShipCaptain sender, string receiver, string message)
        {
            switch (receiver)
            {
                case "Kyiv":
                    ResendMessage(sender.ShipName, _captainKyiv, message);
                    break;
                case "Lviv":
                    ResendMessage(sender.ShipName, _captainLviv, message);
                    break;
                case "Uzhgorod":
                    ResendMessage(sender.ShipName, _captainUzhgorod, message);
                    break;
                default:
                    ReactOnDirrectMessages(sender, receiver, message);
                    break;
            }
        }

        private void ResendMessage(string originSender, ShipCaptain newReceiver, string message)
        {
            string newMessage = $"Forwarded: {message}";
            newReceiver.ReceiveMessage(originSender, newMessage);
        }

        private void ReactOnDirrectMessages(ShipCaptain sender, string receiver, string message)
        {
            if(receiver != "ControlRoom")
            {
                sender.ReceiveMessage("ControlRoom", "Error: Incorrect receiver name.");

                return;
            }

            sender.ReceiveMessage("ControlRoom", "Info: Ok, received.");

            //react on request on information
        }

        private void LogComunication(ShipCaptain sender, string receiver, string message)
        {
            //log logic
        }
    }
}
