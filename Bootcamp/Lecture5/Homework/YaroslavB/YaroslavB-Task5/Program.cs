using System;
using System.Collections.Generic;

namespace YaroslavB_Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region To be done

            //Subtask 1
            //1. Create generic method that accepts collection of drawable objects.
            Console.WriteLine("============ Subtask 1. Drawable objects ============");

            

            //Draw<int>(new int[] { 1, 2, 3 }, 7);

            //Rectangle rec = new Rectangle(new Point(2, 3), new Point(2, 3), new Point(2, 3));
            //rec.Draw();

            //Console.WriteLine(rec.GetType());
            //Console.WriteLine(rec.ToString());
            //Console.WriteLine(typeof());

            #endregion




            //Subtask 2
            //2. You need to calculate how many people leave in each city.
            Console.WriteLine("\n\n============ Subtask 2. Sities and people ============");

            new Survey().ShowSurveyResult();




            //Subtask 3
            //3.  Create class DbResult
            Console.WriteLine("\n\n============ Subtask 3. Class DbResult and list of cities ============");

            var dr = new DataReader();

            var dbResultCities = dr.GetCityNames();

            Console.WriteLine("Obtained cities:");

            foreach (var city in dbResultCities.Value)
            {
                Console.WriteLine(" " + city);
            }

            var dbResultMagicNum = dr.GetMagicNumber();

            Console.WriteLine($"Getting magic Number...\n" +
                                $" operation status: {dbResultMagicNum.IsSucceded}\n" +
                                $" value: {dbResultMagicNum.Value}");





            //Subtask 4
            //4. Create class Package 
            Console.WriteLine("\n\n============ Subtask 4. Class Package ============");

            var foreignPack = new ForeignPackage("15x8x20", "iPhone 14", "Tom")
            {
                SenderCountry = "UK"
             };

            var domesticPack = new DomesticPackage("60x40x90", "TFT Monitor LG T23", "Taras") 
            {
                DepartmentId = 64008
            };

            Delivery<ForeignPackage> foreignDelivery = new Delivery<ForeignPackage>(foreignPack);

            foreignDelivery.DeliverPackage();

            Console.WriteLine();

            Delivery<DomesticPackage> domesticDelivery = new Delivery<DomesticPackage>(domesticPack);

            domesticDelivery.DeliverPackage();

            Console.WriteLine("\n\nPress \'Enter\' to exit...");

            Console.ReadLine();
        }



        //static void Draw<T>(IEnumerable<T> collection, T num) where T : struct
        //{
        //    foreach (var item in collection)
        //    {
        //        Console.WriteLine($"Collection: {item}");
        //    }


        //}
    }
}

