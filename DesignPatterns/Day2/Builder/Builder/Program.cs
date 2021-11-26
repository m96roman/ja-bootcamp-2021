using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var carBuilder = new CarBuilder();

            carBuilder.BuildModelA1("Super premium");
            var a1 = carBuilder.GetCar();
            a1.ListParts();

           
            carBuilder.Reset();
            carBuilder.BuildModelA2("Premium");

            var a2 = carBuilder.GetCar();
            a2.ListParts();

        }
    }
}
