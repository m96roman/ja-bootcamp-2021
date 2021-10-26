using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exchange_Task
{
    public class Validation
    {
        private readonly static List<string> currencies = new() { "EUR", "GBP", "CAD", "JPY", "AUD" };

        public bool IsCorrectCurrency(string currency)
        {
            var regexCurrency = @"^[A-Z]{3}$";
            return Regex.IsMatch(currency, regexCurrency);
        }

        public bool IsCorrectRate(string rate)
        {
            var regexRate = @"(?!0\.00)^(0|[1-9][0-9]{0,2})(,\d{3})*(\.\d{1,2})?$";
            return Regex.IsMatch(rate, regexRate);
        }

        public bool HasThisCurrency(string currency)
        {
            return currencies.Contains(currency);
        }

        public bool IsCorrectAmount(string rate)
        {
            var regexRate = @"(?!0\.00)^((([1-9]\d{0,2}(,\d{3})*|[1-9]\d*)(\.\d{1,4})?)|[1-9]\d*|(0\.\d{1,4})|0)$";
            return Regex.IsMatch(rate, regexRate);
        }

        public bool IsCorrectFileName(string fileName)
        {
            return (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) == -1);
        }

        public void IncorrectDataToUpdate(string currency, string rate)
        {

            if (!IsCorrectRate(rate) && IsCorrectCurrency(currency))
            {
                Console.WriteLine("Incorrect rate!");
            }
            else if (!IsCorrectCurrency(currency) && IsCorrectRate(rate))
            {
                Console.WriteLine("Incorrect currency!");
            }
            else
            {
                Console.WriteLine("Incorrect rate and currency!");
            }
        }

        public void IncorrectDataToConversion(string currency, string amount)
        {
            if (!IsCorrectAmount(amount) && IsCorrectCurrency(currency))
            {
                Console.WriteLine("Incorrect amount!");
            }
            else if (!IsCorrectCurrency(currency) && IsCorrectAmount(amount))
            {
                Console.WriteLine("Incorrect currency!");
            }
            else
            {
                Console.WriteLine("Incorrect amount and currency!");
            }
        }
    }
}
