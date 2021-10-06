using System;

namespace YaroslavB_Task6
{
    class Bidder
    {
        private Func<int, bool> _condition;
        private string _message;

        public Bidder(Func<int, bool> condition, string message)
        {
            _condition = condition;
            _message = message;
        }

        public void CheckNewBidValue(object sender, int value)
        {
            if (_condition(value))
            {
                var temp = _message.Replace("{bidValue}", value.ToString());
                Console.WriteLine(temp);
            }
        }
    }
}
