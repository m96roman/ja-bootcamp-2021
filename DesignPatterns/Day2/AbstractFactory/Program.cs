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

            IClothesFactory longJacketFactory = new LongJacketFactory();
            var longJacket = new Jacket(longJacketFactory);
            longJacket.Print();

            Console.WriteLine("Create MiddleJacket");

            IClothesFactory middleJacketFactory = new MiddleJacketFactory();
            var middleJacket = new Jacket(middleJacketFactory);
            middleJacket.Print();

            Console.WriteLine("Create ShortJacket");

            IClothesFactory shortJacketFactory = new ShortJacketFactory();
            var shortJacket = new Jacket(shortJacketFactory);
            middleJacket.Print();

            Console.ReadKey();
        }

    }
}
