using AbstractFactory.AbstractFactory;
using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create LongJacket");

            IClothesFactory longJacket = new LongJacketFactory();

            longJacket.CreateJacket();


            Console.WriteLine("Create ShortJacket");

            IClothesFactory shortJacket = new ShortJacketFactory();

            shortJacket.CreateJacket();

            Console.WriteLine("Create MiddleJacket");

            IClothesFactory middleJacket = new MiddleJacketFactory();

            middleJacket.CreateJacket();


            Console.ReadKey();
        }

    }
}
