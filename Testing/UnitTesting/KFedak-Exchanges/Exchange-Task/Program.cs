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
            Console.WriteLine("4. Write Stop to leave...");
            Console.WriteLine();
            Console.Write(" Your choose: ");

        }

        public static void Proccess(string mode)
        {
            while (mode != "Stop")
            {
                if (mode == "1")
                {
                    Console.WriteLine("Write wihch currency:");

                    string currency = Console.ReadLine().ToUpper();

                    Console.WriteLine("Write rate to USD:");

                    string rate = Console.ReadLine();

                    if (validation.IsCorrectCurrency(currency) && validation.IsCorrectRate(rate))
                    {
                        if (!validation.HasThisCurrency(currency))
                        {
                            Console.WriteLine("Sorry! We haven`t this currency!");
                            Proccess("1");
                        }
                        else
                        {
                            sql.UpdateData(Convert.ToDecimal(rate), currency);
                        }
                    }
                    else
                    {
                        if (validation.IsCorrectCurrency(currency) && validation.IsCorrectRate(rate))
                        {
                            if (!validation.IsCorrectRate(rate) && validation.IsCorrectCurrency(currency))
                            {
                                Console.WriteLine("Incorrect rate!");
                            }
                            else if (!validation.IsCorrectCurrency(currency) && validation.IsCorrectRate(rate))
                            {
                                Console.WriteLine("Incorrect currency!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect rate and currency!");
                        }

                        Proccess("1");
                    }
                }
                else if (mode == "2")
                {
                    Console.WriteLine("Write amount:");

                    string amount = Console.ReadLine();

                    Console.WriteLine("Write currency:");

                    string currency = Console.ReadLine().ToUpper();

                    if (validation.IsCorrectCurrency(currency) && validation.IsCorrectAmount(amount))
                    {
                        if (!validation.HasThisCurrency(currency))
                        {
                            Console.WriteLine("Sorry! We haven`t this currency!");
                            Proccess("2");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Conversion : ");
                            Console.Write(calculate.CalculateConversionRate(currency, Convert.ToDecimal(amount), sql));
                        }
                    }
                    else
                    {
                        if (validation.IsCorrectCurrency(currency) && validation.IsCorrectAmount(amount))
                        {
                            if (!validation.IsCorrectAmount(amount) && validation.IsCorrectCurrency(currency))
                            {
                                Console.WriteLine("Incorrect amount!");
                            }
                            else if (!validation.IsCorrectCurrency(currency) && validation.IsCorrectAmount(amount))
                            {
                                Console.WriteLine("Incorrect currency!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect amount and currency!");
                        }

                        Proccess("2");
                        break;
                    }
                }
                else if (mode == "3")
                {
                    Console.WriteLine("Write from wihch file:");

                    string enterFile = Console.ReadLine();

                    Console.WriteLine("Write to wihch file:");

                    string endFile = Console.ReadLine();

                    string filePathInput = Path.Combine(Directory.GetCurrentDirectory(), enterFile);

                    string filePathOutput = Path.Combine(Directory.GetCurrentDirectory(), endFile);

                    if (validation.IsCorrectFileName(enterFile))
                    {
                        Console.WriteLine("The filename is invalid");
                        Proccess("3");
                        break;
                    }
                    else
                    {
                        if (File.Exists(enterFile))
                        {
                            calculate.CalculateConversionInBatches(filePathInput, filePathOutput, sql);
                        }
                        else
                        {
                            Console.WriteLine("File isn`t exists");

                            Proccess("3");
                            break;
                        }
                    }
                }

                Menu();
                mode = Console.ReadLine();
            }
        }

    }
}
