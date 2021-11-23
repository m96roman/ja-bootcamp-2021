using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_v1
{
    class JacketA : IJacket
    {
        public IHood Hood()
        {
            return new HoodA();
        }

        public ISleev Sleev()
        {
            return new SleeveA();
        }
    }
}
