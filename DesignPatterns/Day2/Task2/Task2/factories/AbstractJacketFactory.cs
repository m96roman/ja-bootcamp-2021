using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public abstract class AbstractJacketFactory
    {
        public abstract AbstractJacketFirstType CreateJacketFirstType();

        public abstract AbstractJacketSecondType CreateJacketSecondType();

        public abstract AbstractJacketThirdType CreateJacketThirdType();
    }
}
