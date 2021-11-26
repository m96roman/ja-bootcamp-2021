using System;

namespace Task6_FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Street street = new Street();
            HouseFactory house = new HouseFactory();
            var home= house.GetHouse(6);

            home.Build();
            street.AddHouse(home);
            street.Print();

        }
    }
}
