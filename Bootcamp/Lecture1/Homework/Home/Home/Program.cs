using System;
using System.Linq;
using System.Text;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Multiplicator();
            //Program.SwapFirstandLastCharacters();
            //Program.CalcNumbers();
            //Program.FindLargestAndLowest();
            //Program.StringToUpper();
            //Program.IsPosibleToDevide();
            //Program.CheckIfStartsFrom();
            //Program.CalculatePerimeterAndArea();
            //Program.SumAndAvarage();
            //Program.Calculator();
            //Program.PrintNumbersInRange();
        }

        /// <summary>
        /// Create variable and initialize it with any value. Write into console variable name and it's value using nameof operator and interpolation.
        /// </summary>
        static void Multiplicator()
        {
            Console.WriteLine("Enter your first number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number");
            int thirdNumber = Int32.Parse(Console.ReadLine());

            int result = firstNumber * secondNumber * thirdNumber;

            Console.WriteLine($"The multiplication result is: {result}");
        }

        /// <summary>
        /// Swap first and last characters of a given string. Write result to console.
        /// </summary>
        static void SwapFirstandLastCharacters()
        {
            string inputValue = "program";

            StringBuilder sb = new StringBuilder(inputValue);
            sb.Remove(0, 1)
                .Insert(0, "m")
                .Remove(inputValue.Length -1, 1)
                .Insert(inputValue.Length - 1, "p");

            inputValue = sb.ToString();

            Console.WriteLine(inputValue);
        }

        /// <summary>
        /// Read two integers from console. Calculate their sum. If values were equal print triple of their sum, otherwise print sum dividev by 8.
        /// </summary>
        static void CalcNumbers()
        {

            Console.WriteLine("Enter your first number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int sumOfNumbers = firstNumber + secondNumber;

            if(firstNumber == secondNumber)
            {
                int multiplier = 3;
                int result = 0;
                
                for(int i = 0; i < multiplier; i++)
                {
                    result = sumOfNumbers * multiplier;
                }

                Console.WriteLine($"Statment when sum should be tripled is: {result}");
            } else
            {
                Console.WriteLine($"Else statment when sum should be devided by 8 is: {sumOfNumbers / 8}");
            }
        }

        /// <summary>
        /// Find largest and lowest value from three integers.
        /// </summary>

        static void FindLargestAndLowest()
        {
            int[] array = new int[3];
            Console.WriteLine("Enter your first number");
            array[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            array[1] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number");
            array[2] = Int32.Parse(Console.ReadLine());

            int lowest = array.Min();
            int largest = array.Max();

            Console.WriteLine($"The largest number is: {largest} \n the loswer number is: {lowest} ");

        }

        /// <summary>
        /// Read string from console. Create new string where first 5 characters will be in upper case. If string is less then 5 characters do nothing. Print it.
        /// </summary>
        static void StringToUpper()
        {
            Console.WriteLine("Enter your string");
            string input = Console.ReadLine();

            char[] array = input.ToCharArray();
            char[] convertedArray = new char[input.Length];

            for (int i = 0; i <= array.Length - 1 ; i++)
            {
                if (i <= 5)
                {
                    convertedArray[i] = Char.Parse(array[i].ToString().ToUpper());
                } else
                {
                    convertedArray[i] = Char.Parse(array[i].ToString());
                }
            }

            Console.WriteLine(convertedArray);
        }

        /// <summary>
        /// Check if given integer is a multiple of 3 or a multiple of 7.
        /// </summary>
        static void IsPosibleToDevide()
        {
            Console.WriteLine("Enter your number");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 3 == 0 | number % 7 == 0)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }
        }

        /// <summary>
        /// Check if given string starts from 'C#'.
        /// </summary>

        static void CheckIfStartsFrom()
        {
            Console.WriteLine("Enter your string");
            string input = Console.ReadLine().ToLower();

            if (input.StartsWith("C#")){

                Console.WriteLine("Ture");
            } else
            {
                Console.WriteLine("False");
            }
        }

        /// <summary>
        /// Read circle radius from console. Calculate it's perimeter and area.
        /// </summary>
        static void CalculatePerimeterAndArea()
        {
            double radius;
            double perimeter;
            double PI = 3.14;
            double area;

            Console.WriteLine("Input the radius of the circle : ");
            radius = Convert.ToDouble(Console.ReadLine());
           
            perimeter = 2 * PI * radius;
            area = (3.14) * radius * radius;

            Console.WriteLine($"The Perimeter of the circle is: {perimeter} \n And Area is {area}");
        }

        /// <summary>
        /// In a loop read 10 numbers from keyboard. Find their sum and average.
        /// </summary>
        static void SumAndAvarage()
        {
            int[] array = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input the number");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum of numbers is {array.Sum()} \n And Avarage is: {array.Average()}");
        }

        /// <summary>
        /// Write a program to display multiplication table from 1 to n.
        /// </summary>
        static void Calculator()
        {
            int j, i, n;

            Console.Write("Input upto the table number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Multiplication table from 1 to {0} \n", n);
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", j, i, i * j);

                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Read two integers. Print all numbers in range between first and second number that are divisible by 8. If range is invalid print error message.
        /// </summary>
        static void PrintNumbersInRange()
        {
            Console.WriteLine("Enter your first number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int[] range = Enumerable.Range(firstNumber, secondNumber - firstNumber).ToArray();

            int count = 0;
            
            for (int i = 0; i < range.Length; i++)
            {

                if (range[i] % 8 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        /// <summary>
        /// Create enum type for TV channels (5 is enough). Write a switch statement that provides channel avarage rating.
        /// </summary>
        static int TVAvarage(TVChannels channels)
        {
            switch (channels)
            {
                case TVChannels.MTV:
                    return 5;
                case TVChannels.ICTV:
                    return 4;
                case TVChannels.STB:
                    return 3;
                case TVChannels.MUSIC:
                    return 2;
                case TVChannels.MOVIE24:
                    return 1;
                default:
                    return 0;
            }
        }

        public enum TVChannels
        {
            MTV,
            ICTV,
            STB,
            MUSIC,
            MOVIE24
        }

    }
}

