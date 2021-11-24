using AbstractFactory.JacketParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.JacketModels
{
    public class JacketModelC
    {
        private IJacketParts Back = new Back();
        private IJacketParts Front = new Front();
        private IJacketParts Sleeve = new Sleeve();
        private IJacketParts Hood = new Hood();
        private IJacketParts Сollar = new Collar();

        public string SewPartsTogether()
        {
            return $"Jacket Morel C \n{Back.SewOn()} + {Front.SewOn()} + {Sleeve.SewOn()} + {Hood.SewOn()} + {Сollar.SewOn()}\n";
        }
    }
}
