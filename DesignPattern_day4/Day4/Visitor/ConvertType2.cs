using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConvertType2 : IConvert
    {
        public void ConvertCar(Car car)
        {
            Console.WriteLine("{Model:{0}};{Serial Number:{1}}", car.Model,car.SerialNumber);
        }

        public void ConvertDriver(Driver driver)
        {
            Console.WriteLine("{{FName:{0}}};{{SName:{1}}}", driver.FName, driver.SName);
        }
    }
}
