using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    class CommunalService : ISubscriber
    {
        INotifier notifier;
        public CommunalService(INotifier notif)
        {
            this.notifier = notif;
            notifier.RegisterSubscriber(this);
        }
        public void GetNotification(object obj)
        {
            WaterInfo waterInfo = (WaterInfo)obj;
            Console.WriteLine($"CommunalService has got the noification: {waterInfo.info}");
        }
    }
}
