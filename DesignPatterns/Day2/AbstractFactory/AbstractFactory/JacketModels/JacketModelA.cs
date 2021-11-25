using AbstractFactory.JacketParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.JacketModels
{
    public class JacketModelA : IJacketModel
    {
        private IJacketParts Back = new Back();
        private IJacketParts Front = new Front();

        public string SewPartsTogether()
        {
            return $"Jacket Morel A \n{Back.SewOn()} + {Front.SewOn()}\n";
        }
    }
}
