using AbstractFactory.Inteface;
using AbstractFactory.PartsFactory1;
using AbstractFactory.PartsFactory3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    class ShortJacketFactory : IClothesFactory
    {
        public IBack SewingBack()
        {
            return new BackShort();
        }

        public ICollar SewingCollar()
        {
            return new CollarShort();
        }

        public IFront SewingFront()
        {
            return new FrontShort();
        }

        public IHood SewingHood()
        {
            return new HoodShort();
        }

        public ISleeves SewingSleeves()
        {
            return new SleevesShort();
        }
    }
}
