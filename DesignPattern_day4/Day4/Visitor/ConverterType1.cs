using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConverterType1 : IConvert
    {
        public void ConvertCar(Car car)
        {
            Console.WriteLine($"Model:{car.Model}; serialnumber:{car.SerialNumber};");
        }

        public void ConvertDriver(Driver driver)
        {
           
            Console.WriteLine($"FName:{driver.FName}; SName:{driver.SName};");
        }
    }
}
