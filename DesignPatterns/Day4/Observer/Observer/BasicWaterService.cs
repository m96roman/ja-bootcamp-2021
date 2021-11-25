using System.Collections.Generic;

namespace Observer
{
    internal abstract class BasicWaterService : IWaterService
    {

        public List<IClient> Clients { get; protected set; } = new List<IClient>();

        public void AddClient(IClient client)
        {
            Clients.Add(client);
        }

        //From life
        public void RemoveClient(IClient client)
        {
            Clients.Remove(client);
        }

        public abstract void TurnOffEverything();

        public abstract void TurnOnEverything();

        protected void NotifyAll(MessageType messageType, string text)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Notifying clients from {this.GetType().Name}");
            System.Console.WriteLine(new string('-', 20));
            Clients.ForEach(i => i.NotifyFor(messageType, text));
            System.Console.WriteLine(new string('-', 20));
        }
    }
}