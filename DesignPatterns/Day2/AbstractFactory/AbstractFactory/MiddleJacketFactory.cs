using AbstractFactory.Inteface;
using AbstractFactory.PartsFactory1;
using AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    class MiddleJacketFactory:IClothesFactory
    {
        public IBack SewingBack()
        {
            return new BackMiddle();
        }

        public ICollar SewingCollar()
        {
            return new CollarMiddle();
        }

        public IFront SewingFront()
        {
            return new FrontMiddle();
        }

        public IHood SewingHood()
        {
            return new HoodMiddle();
        }

        public ISleeves SewingSleeves()
        {
            return new SleevesMiddle();
        }
    }
}
