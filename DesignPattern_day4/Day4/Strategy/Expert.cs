using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Expert
    {
        private IStrategy _strategy;

        public Expert(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetMethodDecor()
        {
            _strategy.Decor();
        }
    }
}
