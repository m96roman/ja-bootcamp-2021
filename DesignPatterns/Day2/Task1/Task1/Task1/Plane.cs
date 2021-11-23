using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Plane:ITransport
    {
        public void Deilver(Stone someStone)
        {
            Console.WriteLine($"The goods with dimensions {someStone.Even} x {someStone.Height} x {someStone.Width} were sent by plane to {someStone.Adress}");
        }
    }
}
