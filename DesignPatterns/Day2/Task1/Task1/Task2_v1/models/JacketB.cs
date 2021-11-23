using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_v1
{
    class JacketB : IJacket

    {
        public IHood Hood()
        {
            return new HoodB();
        }

        public ISleev Sleev()
        {
            return new SleeveB();
        }
    }
}
