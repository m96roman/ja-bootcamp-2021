using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class NoticationSender: INotifier
    {
        WaterInfo info;

        List<ISubscriber> subscribers;
        public NoticationSender()
        {
            subscribers = new List<ISubscriber>();
            info = new WaterInfo();
        }
        public void RegisterSubscriber(ISubscriber newSubscriber)
        {
            subscribers.Add(newSubscriber);
        }
        public void SendNotification()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.GetNotification(info);
            }

        }
        public void CreateNotification(string newNotification)
        {
            info.info = newNotification;
            SendNotification();
        }
    }
}
