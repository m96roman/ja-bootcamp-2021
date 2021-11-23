using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_v1
{
    class Client
    {
        public void CreatejacketA()
        {
            IJacket jacket = new JacketA();
            IHood hood = jacket.Hood();
            ISleev sleev = jacket.Sleev();
            Console.WriteLine(hood.Name + " " + sleev.Name);

            IJacket jacketB = new JacketB();
            IHood hoodB = jacketB.Hood();
            ISleev sleevB = jacketB.Sleev();
            Console.WriteLine(hoodB.Name + " " + sleevB.Name);


        }
    }
}
