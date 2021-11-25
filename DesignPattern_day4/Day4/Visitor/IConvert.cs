using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
   public  interface IConvert
    {
        void ConvertCar(Car car);
        void ConvertDriver(Driver driver);

    }
}
