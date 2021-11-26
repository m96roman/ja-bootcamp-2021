using AbstractFactory.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
     interface IClothesFactory
    {
        IBack SewingBack();
        IFront SewingFront();
        IHood SewingHood();
        ISleeves SewingSleeves();
        ICollar SewingCollar();
    }

}

