using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    public class PrDepartment
    {
        IHeroActions _heroActions;

        public PrDepartment(IHeroActions heroActions)
        {
            _heroActions = heroActions;
        }

        public void SendNewYearGreeting()
        {
            _heroActions.SendGreeting("Happy New Year!");
        }
    }
}
