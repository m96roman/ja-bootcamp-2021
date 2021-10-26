using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Exchange_Task
{
    class Program
    {
        public static SQLOpeartion sql = new();
        public static CalculateConversion calculate = new();
        public static Validation validation = new();
        public static ExchangeModes ExchangeModes = new();

        static void Main(string[] args)
        {
            Console.WriteLine("*************Exchange Rates ********************");

            Menu();

            Proccess(Console.ReadLine());
        }

        public static void Menu()
        {
            Console.WriteLine("*****************Menu***************");
            Console.WriteLine("1. Update");
            Console.WriteLine("2. Calculate");
            Console.WriteLine("3. Calculate using file");
            Console.WriteLine("4. View Currency");
            Console.WriteLine("5. Stop...");
            Console.WriteLine();
            Console.Write(" Your choose: ");

        }

        public static void Proccess(string mode)
        {
            Console.WriteLine();

            while (mode != "5")
            {

                switch (mode)
                {
                    case "1":
                        if (!ExchangeModes.UpdateCurrencyRate()) { continue; }
                        break;

                    case "2":
                        if (!ExchangeModes.Conversion()) { continue; }
                        break;

                    case "3":
                        if (!ExchangeModes.ConversionBathces()) { continue; }
                        break;

                    case "4":
                        ExchangeModes.ViewCurrency();
                        break;
                    default:
                        Console.WriteLine($"Invalid operation , we have just this..");
                        break;
                }

                Menu();

                mode = Console.ReadLine();
            }
        }
    }
}
