using AbstractFactory.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Jacket : IJacket
    {
        IBack Back { get; set; }
        IHood Hood { get; set; }
        IFront Front { get; set; }
        ICollar Collar { get; set; }
        ISleeves Sleeves { get; set; }

        public Jacket(IClothesFactory factory)
        {
            Back = factory.SewingBack();
            Hood = factory.SewingHood();
            Front = factory.SewingFront();
            Collar = factory.SewingCollar();
            Sleeves = factory.SewingSleeves();
        }

        public void Print()
        {
            string result = $"{Back.GetType().Name}, {Hood.GetType().Name}, {Front.GetType().Name}, {Collar.GetType().Name}, {Sleeves.GetType().Name}";

            Console.WriteLine(result);
        }
    }
}
