using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace YuriyPlLect1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintValue();
            //MultipleNumbers();
            //SwapFirstAndLastChar("troo");
            ToUpperString();

        }

        /// <summary>
        /// Print value of variable and its name
        /// </summary>
        static void PrintValue()
        {
            var value = "test";
            Console.WriteLine($"{nameof(value)} equal {value}");
        }

        /// <summary>
        /// multiplication of three numbers
        /// </summary>
        static void MultipleNumbers()
        {
            int firstValue = ReadNumber();
            int secondValue = ReadNumber();
            int thirdValue = ReadNumber();
            if (firstValue == -1 || secondValue == -1 || thirdValue == -1)
            {
                Console.WriteLine("Try again!");
                return;
            }

            Console.WriteLine("The result is"+ firstValue * secondValue * thirdValue);

            static int ReadNumber()
            {
                Console.WriteLine("Please input  number");
                var firstNumber = Console.ReadLine().Trim();
                int firstValue;

                if (!int.TryParse(firstNumber, out firstValue))
                {
                    Console.WriteLine("Please input only integer.");
                    return -1;
                }

                return firstValue;
            }

        }

        /// <summary>
        /// Swap first and last characters of a given string.
        /// </summary>
        /// <param name="value"></param>
        static void SwapFirstAndLastChar(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Value can not be an empty");
                return;
            }
            var first = value.First();
            var last = value.Last();

            Console.WriteLine(last.ToString() + value.Substring(1, value.Length - 2) + first.ToString()); 
        }

        /// <summary>
        /// Read two integers from console. Calculate their sum.
        /// If values were equal print triple of their sum, otherwise print sum dividev by 8
        /// </summary>
        static void SumoOrDivide()
        {
            Console.WriteLine("Please input first number");
            var firstNumber = Console.ReadLine().Trim();
            int firstValue;

            if (!int.TryParse(firstNumber, out firstValue))
            {
                Console.WriteLine("Please input only integer. Try again.");
                return;
            }

            Console.WriteLine("Please input second number");
            var secondNumber = Console.ReadLine().Trim();
            int secondValue;

            if (!int.TryParse(secondNumber, out secondValue))
            {
                Console.WriteLine("Please input only integer. Try again.");
                return;
            }

            double result = firstValue == secondValue ? firstValue + secondValue : (firstValue + secondValue) / 8;

            Console.WriteLine(result);
        }

        /// <summary>
        /// Find largest and lowest value from three integers.
        /// </summary>
        /// <param name="someNumbers"></param>
        static void FindLargestAndLowest(params int[] someNumbers)
        {
            if (someNumbers is null || someNumbers.Length < 3 || someNumbers.Length > 3)
            {
                Console.WriteLine($"In array {nameof(someNumbers)} should be 3 values ");
                return;
            }
            Console.WriteLine($"The largest number is{someNumbers.Max()} and the lowest is {someNumbers.Min()}!");

        }

        /// <summary>
        /// Create new string where first 5 characters will be in upper case. 
        /// If string is less then 5 characters do nothing.
        /// </summary>
        static void ToUpperString()
        {
            Console.WriteLine("Please input some text");
            var text = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Value can not be an empty");
                return;
            }
            if (text.Length < 5)
            {
                Console.WriteLine(text);
            }

            //Console.WriteLine(new string(text.Take(5).ToArray()).ToUpper() + new string(text.Skip(5).ToArray()).ToString());
            string result = string.Join("", text.Take(5)).ToUpper() + string.Join("", text.Skip(5));
            Console.WriteLine(result);
        }

        /// <summary>
        /// Check if given integer is a multiple of 3 or a multiple of 7.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool IsMultipleOfThreeOrSeven(int value)
        {
            return (value % 3) == 0 || (value % 7) == 0;
        }

        /// <summary>
        /// Check if given string starts from 'C#'.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool IsStartFrom(string value)
{
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Value can not be an empty");
                return false;
            }
            return value.StartsWith("C#");
        }

        /// <summary>
        /// Calculate  perimeter and area of circle
        /// </summary>
        static void FindAreaAndPerimeter()
        {
            Console.WriteLine("Please input radius of circle");
            var firstNumber = Console.ReadLine().Trim();
            int radius;

            if (!int.TryParse(firstNumber, out radius))
            {
                Console.WriteLine("Please input only integer. Try again.");
                return;
            }
            if (radius <= 0)
            {
                Console.WriteLine("Radius can not be less or equal 0. Try again.");
                return;
            }

            Console.WriteLine("Area of circle is" + Math.PI * radius * radius + "and Perimeter is" + 2 * Math.PI * radius);
            
        }

        /// <summary>
        /// Find  sum and average of 10 numbers
        /// </summary>
        static void FindAvg()
        {
            List<int> container = new List<int>();
            var counter = 1;
            while (counter != 10)
            {
                int number;
                if (!ReadNumber(out number))
                {
                    Console.WriteLine("Please input only integer. Try agin!");
                    return;
                }
                container.Add(number);
                counter++;
            }

            Console.WriteLine("Sum of ten numbers is" + container.Sum() + "Average is" + (double)container.Sum() / 10);
            static bool ReadNumber( out int value)
            {
                Console.WriteLine("Please input integer number");
                
                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    return false;
                }
                return true;
            }


        }

        /// <summary>
        /// display multiplication table
        /// </summary>
        /// <param name="number"></param>
        static void PresentMultiplicationTable(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("number has to be more than 0");
                return;
            }
            int counter = 1;
            while (counter != number)
            {
                for (int x = 1; x <= number; x++)
                {
                    Console.Write($"{counter}X{x}=" + counter * x);
                }
                Console.WriteLine();
                counter++;
            }
        }

        /// <summary>
        /// Print all numbers in range between first and second number that are divisible by 8
        /// If range is invalid return null
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        static IEnumerable<int> DivisibleByEight(int firstNumber, int secondNumber)
        {
            var container = new List<int>();
            if ((secondNumber - firstNumber) <= 0)
            {
                Console.WriteLine("Range is not valid. Please input first number less than second");
                return null; 
            }

            for (int x = firstNumber; x <= secondNumber; x++)
            {
                if (x % 8 == 0)
                {
                    container.Add(x);
                }
            }

            return container;

        }

        /// <summary>
        /// provides channel avarage rating
        /// </summary>
        /// <param name="tvChannl"></param>
        static void AvgRaring(TV tvChannl)
        {
            switch (tvChannl)
            {
                case TV.Sky:
                    Console.WriteLine($"Rating is for {nameof(TV.Sky)} " + TV.Sky);
                    break;
                case TV.HBO:
                    Console.WriteLine($"Rating is for {nameof(TV.HBO)} " + TV.HBO);
                    break;
                case TV.Netflix:
                    Console.WriteLine($"Rating is for {nameof(TV.Netflix)} " + TV.Netflix);
                    break;
                case TV.AppleTv:
                    Console.WriteLine($"Rating is for {nameof(TV.AppleTv)} " + TV.AppleTv);
                    break;
                case TV.SkySport:
                    Console.WriteLine($"Rating is for {nameof(TV.SkySport)} " + TV.SkySport);
                    break;
                default:
                    Console.WriteLine("Can not find the channel");
                    break;
            }
        }

    }
    enum TV 
    { 
        Sky = 30,
        HBO = 38,
        Netflix = 49,
        AppleTv = 59,
        SkySport
    }

}
