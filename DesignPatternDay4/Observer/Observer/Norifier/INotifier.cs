using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface INotifier
    {
        public void RegisterSubscriber(ISubscriber newSubscriber);
        public void SendNotification();
    }
}
