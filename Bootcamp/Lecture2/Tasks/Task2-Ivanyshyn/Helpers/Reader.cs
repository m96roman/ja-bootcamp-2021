using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_Ivanyshyn.Helpers
{
    public class Reader
    {
        /// <summary>
        /// Reads array
        /// First his lenght then other elements
        /// </summary>
        /// <returns><c>new int[]</c> array</returns>
        public static int[] ReadArray()
        {
            int length = ReadNumber(name: "lenght of array");
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = ReadNumber(name: "element -" + i);
            }

            return array;
        }

        /// <summary>
        /// Reads number
        /// </summary>
        /// <returns>number</returns>
        public static int ReadNumber(string name = "integer number")
        {
            int num = 0;
            Console.WriteLine($"Enter a valid {name}: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Write valid number!");
            }

            return num;
        }

        /// <summary>
        /// Reads double
        /// </summary>
        /// <returns>readed double</returns>
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

        /// <summary>
        /// Reads string
        /// </summary>
        /// <returns>readed string</returns>
        public static string ReadString(string name = "Enter string")
        {
            string val = default;
            Console.WriteLine(name);
            while (string.IsNullOrWhiteSpace(val = Console.ReadLine()))
            {
                Console.WriteLine("Write valid string!");
            }

            return val;
        }

    }

}

