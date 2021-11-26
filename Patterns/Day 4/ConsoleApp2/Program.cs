using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Observer */

            // create vodokanal
            Vodokanal vodokanal = new Vodokanal();

            // create subscribers
            User user = new User("Andriy", vodokanal);
            Entrepreneur entrepreneur = new Entrepreneur("Volodymyr Ivanovych", vodokanal);
            UtilityService utilityService = new UtilityService("LKP Green", vodokanal);

            // block the water 
            Console.WriteLine();
            vodokanal.BlockTheWater();

            // unsubscribe enterpreneur
            Console.WriteLine();
            entrepreneur.UnSubscribe();

            // block the water
            Console.WriteLine();
            vodokanal.BlockTheWater();
        }
    }
}
