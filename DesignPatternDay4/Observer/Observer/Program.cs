using Observer.Subscribers;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NoticationSender notifier = new NoticationSender();
            
            User user = new User(notifier);
            Company company = new Company(notifier);
            CommunalService service = new CommunalService(notifier);

            notifier.CreateNotification("no water 26.11.2021");
        }
    }
}
