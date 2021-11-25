using AbstractFactory.JacketParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.JacketModels
{
    public class JacketModelB
    {
        private IJacketParts Back = new Back();
        private IJacketParts Front = new Front();
        private IJacketParts Sleeve = new Sleeve();

        public string SewPartsTogether()
        {
            return $"Jacket Morel B \n{Back.SewOn()} + {Front.SewOn()} + {Sleeve.SewOn()}\n";
        }
    }
}
