using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class LvivAgent
    {
        private AbstractJacketFirstType _someFirstTypeJacket;
        private AbstractJacketSecondType _someSecondTypeJacket;
        private AbstractJacketThirdType _someThirdTypeJacket;

        public LvivAgent(AbstractJacketFactory factory)
        {
            _someFirstTypeJacket = factory.CreateJacketFirstType();
            _someSecondTypeJacket = factory.CreateJacketSecondType();
            _someThirdTypeJacket = factory.CreateJacketThirdType();
        }
    }

    public class Store
    {
        public Store()
        {
            LvivAgent lvivFactory = new LvivAgent(new JacketFactoryTypeOne());
        }
    }
}
