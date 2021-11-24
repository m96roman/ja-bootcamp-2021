using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class JacketFactoryTypeOne : AbstractJacketFactory
    {
        public override AbstractJacketFirstType CreateJacketFirstType()
        {
            Console.WriteLine("type1");
            return new JacketFirstType();
        }

        public override AbstractJacketSecondType CreateJacketSecondType()
        {
            Console.WriteLine("type1");
            return new JacketSecondType();
        }

        public override AbstractJacketThirdType CreateJacketThirdType()
        {
            Console.WriteLine("type1");
            return new JacketThirdType();
        }
    }
}
