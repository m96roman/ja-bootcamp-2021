using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Ship: Transport
    {
        public Ship(string name) : base(name)
        { }
        public override Goods Send()
        {
            return new StoneGoods();
        }
    }
}
