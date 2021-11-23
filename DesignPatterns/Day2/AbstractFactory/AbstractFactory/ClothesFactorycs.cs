using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class ClothesFactorycs : IClothesFactory
    {
        public IJacket CreateLongJacket()
        {
            return new LongJacket();
        }

        public IJacket CreateMiddleJacket()
        {
            return new MiddleJacket();
        }

        public IJacket CreateShortJacket()
        {
            return new ShortJacket();
        }
    }
}
