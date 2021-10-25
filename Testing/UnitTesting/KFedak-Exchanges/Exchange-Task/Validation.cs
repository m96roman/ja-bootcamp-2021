using System;
using System.Collections.Generic;
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
            var regexRate = @"^((([1-9]\d{0,2}(,\d{3})*|[1-9]\d*)(\.\d{1,4})?)|[1-9]\d*|(0\.\d{1,4})|0)$";
            return Regex.IsMatch(rate, regexRate);
        }

        public bool HasThisCurrency(string currency)
        {
            return currencies.Contains(currency);
        }

        public bool IsCorrectAmount(string rate)
        {
            var regexRate = @"^((([1-9]\d{0,2}(,\d{3})*|[1-9]\d*)(\.\d{1,4})?)|[1-9]\d*|(0\.\d{1,4})|0)$";
            return Regex.IsMatch(rate, regexRate);
        }

        public bool IsCorrectFileName(string fileName)
        {
            return (fileName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1);
        }

    }
}
