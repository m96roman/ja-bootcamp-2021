using System;

namespace HelperMethods
{
    public static class Reader
    {
        /// <summary>
        /// Reads number
        /// </summary>
        /// <returns>number</returns>
        public static int ReadNumber()
        {
            int num = 0;
            Console.WriteLine("Enter a valid integer number: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Write valid number!");
            }
            return num;
        }
        public static double ReadDouble()
        {
            double num = 0;
            Console.WriteLine("Enter a valid integer number: ");
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Write valid number!");
            }
            return num;
        }
        public static string ReadString()
        {
            string val = default;
            Console.WriteLine("Enter string");
            while (string.IsNullOrWhiteSpace(val = Console.ReadLine()))
            {
                Console.WriteLine("Write valid string!");
            }
            return val;
        }
    }

}
