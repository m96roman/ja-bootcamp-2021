using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.JacketParts;

namespace Task2
{
    public class JacketOrderAgency
    {
        public Tuple<IHood, ISleeve, IFrontPart> MakeOrder(AbstractJacketFactory jacketFactory)
        {        
            return Tuple.Create(jacketFactory.CreateHood(), jacketFactory.CreateSleeve(), jacketFactory.CreateFrontPart());
        }
    }
}
