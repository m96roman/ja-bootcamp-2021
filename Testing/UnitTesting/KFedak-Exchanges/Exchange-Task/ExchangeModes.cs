using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Task
{
    public class ExchangeModes
    {
        public SQLOpeartion Sql { get; set; }
        public CalculateConversion Calculate { get; set; }
        public Validation Validation { get; set; }

        public ExchangeModes()
        {
            Sql = new SQLOpeartion();
            Calculate = new CalculateConversion();
            Validation = new Validation();
        }

        public bool Conversion()
        {
            bool conversionStatus = true;

            Console.WriteLine("Write amount:");

            string amount = Console.ReadLine();

            Console.WriteLine("Write currency:");

            string currency = Console.ReadLine().ToUpper();

            if (Validation.IsCorrectCurrency(currency) && Validation.IsCorrectAmount(amount))
            {
                if (!Validation.HasThisCurrency(currency))
                {
                    Console.WriteLine("Sorry! We haven`t this currency!");
                    conversionStatus = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Conversion : ");
                    Console.Write(Calculate.CalculateConversionRate(currency, Convert.ToDecimal(amount), Sql));
                }
            }
            else
            {
                Validation.IncorrectDataToConversion(currency, amount);
                conversionStatus = false;
            }

            return conversionStatus;
        }

        public bool UpdateCurrencyRate()
        {
            bool updateStatus = true;

            Console.WriteLine("Write wihch currency:");

            string currency = Console.ReadLine().ToUpper();

            Console.WriteLine("Write rate to USD:");

            string rate = Console.ReadLine();

            if (Validation.IsCorrectCurrency(currency) && Validation.IsCorrectRate(rate))
            {
                if (!Validation.HasThisCurrency(currency))
                {
                    Console.WriteLine("Sorry! We haven`t this currency!");
                    updateStatus = false;
                }

                Sql.UpdateData(Convert.ToDecimal(rate), currency);
            }
            else
            {
                Validation.IncorrectDataToUpdate(currency, rate);
                updateStatus = false;
            }

            return updateStatus;
        }

        public bool ConversionBathces()
        {
            bool conversionStatus = true;

            Console.WriteLine("Write from wihch file:");

            string enterFile = Console.ReadLine();

            Console.WriteLine("Write to wihch file:");

            string endFile = Console.ReadLine();

            string filePathInput = Path.Combine(Directory.GetCurrentDirectory(), enterFile);

            string filePathOutput = Path.Combine(Directory.GetCurrentDirectory(), endFile);

            if (Validation.IsCorrectFileName(enterFile))
            {
                Console.WriteLine("The filename is invalid");

                conversionStatus = false;
            }
            else
            {
                if (File.Exists(enterFile))
                {
                    Calculate.CalculateConversionInBatches(filePathInput, filePathOutput, Sql);
                }
                else
                {
                    Console.WriteLine("File isn`t exists");

                    conversionStatus = false;
                }
            }

            return conversionStatus;
        }

        public void ViewCurrency()
        {
            Sql.SelectData();
            Console.WriteLine(Sql.InformationFromQuery.ToString());
        }
    }
}
