using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subscribers
{
    class User : ISubscriber
    {
        INotifier notifier;
        public User(INotifier notif)
        {
            this.notifier = notif;
            notifier.RegisterSubscriber(this);
        }
        public void GetNotification(object obj)
        {
            WaterInfo waterInfo = (WaterInfo)obj;
            Console.WriteLine($"User has got the noification: {waterInfo.info}");
        }
    }
}
