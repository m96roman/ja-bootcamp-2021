using System;
using System.Collections.Generic;

namespace YaroslavB_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Subtask 1
            //1. Create generic method that accepts collection of drawable objects.
            Console.WriteLine("============ Subtask 1. Drawable objects ============");

            var points = new List<Point>
            {
                new Point(3,4),
                new Point(5,6),
                new Point(2,3),
                new Point(1,4),
                new Point(4,5)
            };
            
            Designer.Draw<Point>(points);

            Console.WriteLine();
            Console.WriteLine();

            var rectangles = new Rectangle[]
            {
                new Rectangle(new Point(3, 4), new Point(4, 32), new Point(32, 3)),
                new Rectangle(new Point(34, 4), new Point(4, 5), new Point(5, 34)),
                new Rectangle(new Point(5, 23), new Point(23, 4), new Point(4, 5))
            };

            Designer.Draw<Rectangle>(rectangles);



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

            MeestExpress foreignDelivery = new MeestExpress();
            foreignDelivery.DeliverPackage(foreignPack);
            foreignDelivery.InformRecipient(foreignPack);
            Console.WriteLine();

            NovaPoshta domesticDelivery = new NovaPoshta();
            domesticDelivery.DeliverPackage(domesticPack);
            domesticDelivery.InformRecipient(domesticPack);

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}

