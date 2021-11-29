using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterWay waterWay = new WaterWay();

            Console.WriteLine();

            var user = new User("Ivan Ivanovych", waterWay);
            var entrepreneur = new Entrepreneur("Petro", waterWay);
            var utilities = new Utilities("GAZ", waterWay);

            waterWay.Attention();

            Console.WriteLine();

            user.ActionAfterNotification();
            entrepreneur.ActionAfterNotification();
            utilities.ActionAfterNotification();

        }
    }
}
