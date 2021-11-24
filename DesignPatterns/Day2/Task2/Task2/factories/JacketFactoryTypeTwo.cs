﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class JacketFactoryTypeTwo : AbstractJacketFactory
    {
        public override AbstractJacketFirstType CreateJacketFirstType()
        {
            Console.WriteLine("type2");
            return new JacketFirstType();
        }

        public override AbstractJacketSecondType CreateJacketSecondType()
        {
            Console.WriteLine("type2");
            return new JacketSecondType();
        }

        public override AbstractJacketThirdType CreateJacketThirdType()
        {
            Console.WriteLine("type2");
            return new JacketThirdType();
        }
    }
}