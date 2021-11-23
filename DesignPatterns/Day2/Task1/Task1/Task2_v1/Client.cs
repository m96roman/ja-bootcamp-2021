using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_v1
{
    class Client
    {
        public void Createjacket(IJacket jaket)
        {
            IJacket jacket = jaket;
            IHood hood = jacket.Hood();
            ISleev sleev = jacket.Sleev();
            Console.WriteLine(hood.Name + " " + sleev.Name);
        }
    }
}
