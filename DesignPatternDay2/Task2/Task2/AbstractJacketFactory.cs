using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.JacketParts;

namespace Task2
{
    public abstract class AbstractJacketFactory
    {
        public abstract IHood CreateHood();
        public abstract ISleeve CreateSleeve();
        public abstract IFrontPart CreateFrontPart();
    }
}
