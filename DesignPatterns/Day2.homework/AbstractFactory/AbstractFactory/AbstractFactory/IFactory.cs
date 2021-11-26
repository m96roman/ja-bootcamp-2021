using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IFactory
    {
         void addHood();
         void addCollar();
         void addFront();
         void addBack();
         IProduct addAllPartsTogether();
    }
}
