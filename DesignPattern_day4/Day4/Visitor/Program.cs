using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IConvert convert = new ConverterType1();
            IConvert convert1 = new ConvertType2();
            var member = new Car();
            var driver = new Driver();
          
            member.Accept(convert);
            driver.Accept(convert1);
        }
    }
}
