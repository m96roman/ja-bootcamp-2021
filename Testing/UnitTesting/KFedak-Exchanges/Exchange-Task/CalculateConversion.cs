using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Task
{
    public class CalculateConversion
    {
        public IFileWrapper fileWrapper = new FileWrapper();

        public decimal CalculateConversionRate(string currency, decimal amount, SQLOpeartion sQL)
        {
            return (sQL.SelectRateForCurrency(currency) * amount);
        }

        public void CalculateConversionInBatches(string filePathEnter, string filePathEnd, SQLOpeartion sQL)
        {
            decimal result;
            StringBuilder builder = new StringBuilder();
            var informationAboutCurrency = SetDateFromFile(filePathEnter);
            foreach (var element in informationAboutCurrency)
            {
                result = sQL.SelectRateForCurrency(element.Item2) * element.Item1;
                builder.Append($"{element.Item1} \t {element.Item2} \t => {result} USD\n");
            }
            fileWrapper.WriteInFile(filePathEnd, builder.ToString());
        }

        public List<Tuple<decimal, string>> SetDateFromFile(string filePath)
        {
            List<Tuple<decimal, string>> informationAboutCurrency = new();
            string information = fileWrapper.ReadDataFromFile(filePath);
            string[] lines = Array.ConvertAll(information.Split('\n', StringSplitOptions.RemoveEmptyEntries), p => p.Trim());

            foreach (var line in lines)
            {
                var currencyInfo = Array.ConvertAll(line.Split('|'), p => p.Trim());
                informationAboutCurrency.Add(new Tuple<decimal, string>(Convert.ToDecimal(currencyInfo[0]), currencyInfo[1]));
            }

            return informationAboutCurrency;
        }
    }
}
