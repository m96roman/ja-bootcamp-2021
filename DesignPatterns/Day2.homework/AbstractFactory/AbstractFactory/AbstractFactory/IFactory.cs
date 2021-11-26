using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IFactory
    {
        IProduct addHood(IProduct product);
        IProduct addCollar(IProduct product);
        IProduct addFront(IProduct product);
        IProduct addBack(IProduct product);
        IProduct addAllPartsTogether(IProduct product);
    }
}
