using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LongJacket : IJacket
    {
        public string Name => "LongJacket";

        public LongJacket()
        {
            Console.WriteLine($"{SewingBack()}{Name}," +
                $"{SewingCollar()}{Name}," +
                $"{SewingFront()}{Name}," +
                $"{SewingHood()}{Name}," +
                $"{SewingSleeves()}{Name}");
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
