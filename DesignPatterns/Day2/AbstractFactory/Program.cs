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
            IClothesFactory clothesFactory = new ClothesFactorycs();

            Console.WriteLine("Create ShortJacket");
            clothesFactory.CreateShortJacket();

            Console.WriteLine("Create MiddleJacket");
            clothesFactory.CreateMiddleJacket();

            Console.WriteLine("Create LongJacket");
            clothesFactory.CreateLongJacket();

            Console.ReadKey();
        }

    }
}
