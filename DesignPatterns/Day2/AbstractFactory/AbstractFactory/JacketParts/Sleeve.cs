using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.JacketParts
{
    class Sleeve : IJacketParts
    {
        public string SewOn()
        {
            return "Sleeve";
        }
    }
}
