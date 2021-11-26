using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class JacketFactoryTypeThree : AbstractJacketFactory
    {
        public override AbstractJacketFirstType CreateJacketFirstType()
        {
            Console.WriteLine("type3");
            return new JacketFirstType();
        }

        public override AbstractJacketSecondType CreateJacketSecondType()
        {
            Console.WriteLine("type3");
            return new JacketSecondType();
        }

        public override AbstractJacketThirdType CreateJacketThirdType()
        {
            Console.WriteLine("type3");
            return new JacketThirdType();
        }
    }
}
