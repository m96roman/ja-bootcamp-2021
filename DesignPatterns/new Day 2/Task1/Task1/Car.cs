using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Car : Transport
    {
        public Car(string name) : base(name)
        { }
        public override Goods Send()
        {
            return new StoneGoods();
        }
    }
}
