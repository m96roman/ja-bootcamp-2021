using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    class Company : ISubscriber
    {
        INotifier notifier;
        public Company(INotifier notif)
        {
            this.notifier = notif;
            notifier.RegisterSubscriber(this);
        }
        public void GetNotification(object obj)
        {
            WaterInfo waterInfo = (WaterInfo)obj;
            Console.WriteLine($"Company has got the noification: {waterInfo.info}");
        }
    }
}
