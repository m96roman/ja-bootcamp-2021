using System;
using Task2.JcketFactories;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            JacketOrderAgency shopUzhgorod = new JacketOrderAgency();
            JacketOrderAgency shopLviv = new JacketOrderAgency();
            JacketOrderAgency shopKyiv = new JacketOrderAgency();

            //one shop can make orders from different factories which make different models
            Console.WriteLine("order from shopUzhgorod");   
            shopUzhgorod.MakeOrder(new JacketModelAFactory());
          
            Console.WriteLine("order from shopUzhgorod");
            shopUzhgorod.MakeOrder(new JacketModelBFactory());

            //different shops can make order from one factory
            Console.WriteLine("order from shopLviv");
            shopLviv.MakeOrder(new JacketModelCFactory());
          
            Console.WriteLine("order from shopKyiv");
            shopKyiv.MakeOrder(new JacketModelCFactory());




        }
    }
}
