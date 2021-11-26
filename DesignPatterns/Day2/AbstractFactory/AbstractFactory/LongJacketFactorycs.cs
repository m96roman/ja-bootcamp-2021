using AbstractFactory.Inteface;
using AbstractFactory.PartsFactory1;
using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
     class LongJacketFactory : IClothesFactory
    {
        public IBack SewingBack()
        {
            return new BackLong();
        }

        public ICollar SewingCollar()
        {
           return new CollarLong();
        }

        public IFront SewingFront()
        {
            return new FrontLong();
        }

        public IHood SewingHood()
        {
            return new HoodLong();
        }

        public ISleeves SewingSleeves()
        {
            return new SleevesLong();
        }
    }
}
