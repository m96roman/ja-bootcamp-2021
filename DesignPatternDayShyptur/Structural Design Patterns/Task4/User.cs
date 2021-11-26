using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class User
    {
        public void GetRoot(Component component1)
        {
            Console.WriteLine($"Root: {component1.GetRoot()}");
        }
    }
}
