using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Truck : ITransport
    {
        public void Deilver(Stone someStone)
        {
            Console.WriteLine($"The goods with dimensions {someStone.Even} x {someStone.Height} x {someStone.Width} were sent by truck to {someStone.Adress}");
        }
    }
}
