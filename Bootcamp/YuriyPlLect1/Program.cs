using System;
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

            Console.WriteLine("Please input third number");
            var thirdNumber = Console.ReadLine().Trim();
            int thirdValue;

            if (!int.TryParse(thirdNumber, out thirdValue))
            {
                Console.WriteLine("Please input only integer. Try again.");
                return;
            }

            Console.WriteLine("The result is"+ firstValue * secondValue * thirdValue);
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

            var result = firstValue == secondValue ? firstValue + secondValue : (firstValue + secondValue) / 8;

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

            Console.WriteLine(new string(text.Take(5).ToArray()).ToUpper() + new string(text.Skip(5).ToArray()).ToString());
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
            return value.Trim().Take(2).ToArray().ToString() == "C#";
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

            Console.WriteLine("Area of circle is" + 3.14 * radius * radius + "and Perimeter is" + 2 * 2.14 * radius);
            
        }

    }
}
