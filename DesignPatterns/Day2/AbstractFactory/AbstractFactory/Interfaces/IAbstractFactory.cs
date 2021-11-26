using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class IAbstractFactory
    {
        public virtual void CreateModelA(){}

        public virtual void CreateModelB(){}

        public virtual void CreateModelC(){ }
    }
}
