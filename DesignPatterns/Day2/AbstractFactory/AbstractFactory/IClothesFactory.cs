using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IClothesFactory
    {
        IJacket CreateJacket();
        string SewingBack();
        string SewingFront();
        string SewingHood();
        string SewingSleeves();
        string SewingCollar();
    }

}

