using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    class ShortJacketFactory:IClothesFactory
    {
        public IJacket CreateJacket()
        {
            var jacket = new ShortJacket();
            Console.WriteLine($"{SewingBack()}{jacket.Name}," +
               $"{SewingCollar()}{jacket.Name}," +
               $"{SewingFront()}{jacket.Name}," +
               $"{SewingHood()}{jacket.Name}," +
               $"{SewingSleeves()}{jacket.Name}");
            return jacket;
        }

        public string SewingBack()
        {
            return "sewing a back  for ";
        }

        public string SewingCollar()
        {
            return "sewing a collar for ";
        }

        public string SewingFront()
        {
            return "sewing a front for ";
        }

        public string SewingHood()
        {
            return "sewing a hood for ";
        }

        public string SewingSleeves()
        {
            return "sewing a sleeves for ";

        }

    }
}
