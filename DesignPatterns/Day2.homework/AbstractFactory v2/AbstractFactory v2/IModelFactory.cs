using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_v2
{
    interface IModelFactory
    {
        IBack MakeBack();
        ICollar MakeCollar();
        IFront MakeFront();
        IHood MakeHood();
    }
}
