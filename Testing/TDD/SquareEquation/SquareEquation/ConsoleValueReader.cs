using System;

namespace SquareEquation
{
    internal class ConsoleValueReader
    {
        private ILogger _logger;

        public ConsoleValueReader() : this(new Logger())
        {
            
        }

        public ConsoleValueReader(ILogger logger)
        {
            _logger = logger;
        }


        public (double a, double b, double c) ReadValues(string source = "N/A")
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("Enter three coefficients - A, B nad C one by one through \'Enter\'\n" +
                              "enter \'exit\' to close the program\n");

            while(true)
            {
                if(!TryToGetValue(ref a, "A") || !TryToGetValue(ref b, "B") || !TryToGetValue(ref c, "C"))
                {
                    Console.WriteLine("\nPlease try again...");
                    continue;
                }

                return (a, b, c);
            }
        }

        private bool TryToGetValue(ref double refValue, string name)
        {
            Console.WriteLine($"Enter value for <{name}>");
            string inputStr = Console.ReadLine();

            if (inputStr.ToLower() == "exit")
            {
                _logger.Log("Application is closing...", MessageType.Warning);
                Environment.Exit(0);
            }

            if (ValidateInputString(inputStr, out double value))
            {
                refValue = value;
                return true;
            }

            _logger.Log("Error! All values must contains only numbers and/or floating point", MessageType.Error);

            return false;
        }

        private bool ValidateInputString(string str, out double value)
        {
            bool status = double.TryParse(str, out double result);
            value = result;

            return status;
        }

    }

}