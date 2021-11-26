using ConsoleApp5.Abstracts;

namespace ConsoleApp5
{
    public class DispatcherMediator : Mediator
    {
        public Captain KyivShip { get; set; }
        public Captain LvivShip { get; set; }
        public Captain UzhhorodShip { get; set; }

        public override void Send(string message, Captain captain)
        {
            if(captain == KyivShip)
            {
                LvivShip.Notify(message);
                UzhhorodShip.Notify(message);
            }
            else if(captain == LvivShip)
            {
                KyivShip.Notify(message);
                UzhhorodShip.Notify(message);
            }
            else
            {
                LvivShip.Notify(message);
                KyivShip.Notify(message);
            }
        }
    }
}
