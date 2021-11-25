using System.Collections.Generic;

namespace Observer
{
    internal interface IWaterService
    {
        List<IClient> Clients { get; }

        void AddClient(IClient client);
        void RemoveClient(IClient client);
        void TurnOffEverything();
        void TurnOnEverything();
    }
}