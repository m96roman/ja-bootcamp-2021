using System;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create variable and initialize it with any value. Write into console variable name and it's value using nameof operator and interpolation.
            ShowNameAndValue();

            //2. Read three numbers from console and print their multiplication.
            //PrintMultiplication(3);

            //3. Swap first and last characters of a given string. Write result to console.
            //SwapCharacters();

            //4. Read two integers from console. Calculate their sum. If values were equal print triple of their sum, otherwise print sum dividev by 8.
            //PrintSum();

            //5. Find largest and lowest value from three integers.
            //FindMinMaxValue();

            //6. Read string from console. Create new string where first 5 characters will be in upper case. If string is less then 5 characters do nothing. Print it.
            //ToUpperSubstring();

            //7. Check if given integer is a multiple of 3 or a multiple of 7.
            //CheckOnMultiple();

            //8. Check if given string starts from 'C#'.
            //CheckStartString();

            //9. Read circle radius from console. Calculate it's perimeter and area.
            //ShowCirclePerimeterArea();

            //10. In a loop read 10 numbers from keyboard. Find their sum and average.
            //CalcSumAverage();

            //11. Write a program to display multiplication table from 1 to n.
            //ShowMatrix();

            //12. Read two integers. Print all numbers in range between first and second number that are divisible by 8. If range is invalid print error message.
            //PrintNumbersInRAnge();

            //13. Create enum type for TV channels (5 is enough). Write a switch statement that provides channel avarage rating.
            //TVChannelsRating();



            Console.ReadKey();
        }


        /// <summary>
        /// 1. Create variable and initialize it with any value. Write into console variable name and it's value using nameof operator and interpolation.
        /// </summary>
        static void ShowNameAndValue()
        {
            string userName = "Tom";

            Console.WriteLine($"Variable name: {nameof(userName)}, variable value: {userName}");
        }


        /// <summary>
        /// 2. Read three numbers from console and print their multiplication.
        /// </summary>
        /// <param name="numbersCount"></param>
        static void PrintMultiplication(int numbersCount = 3)
        {
            int count = numbersCount;

            Console.WriteLine("Enter three numbers one by one through \'Enter\'");

            int[] numbers = new int[count];
            var i = 0;
            while(true)
            {
                if(IsNumber(Console.ReadLine(), out int number))
                {
                    numbers[i] = number;
                }

                else
                {
                    Console.WriteLine("It is not a number, please try again");
                    continue;
                }


                i++;

                if (i < numbers.Length)
                {
                    Console.WriteLine("Good! Type next number");
                    continue;
                }
                break;
            }

            var multi = 1;
            foreach(var j in numbers)
            {
                multi *= j;
            }

            Console.WriteLine($"Multiplied numbers: {multi}");
        }


        /// <summary>
        /// 3. Swap first and last characters of a given string. Write result to console.
        /// </summary>
        static void SwapCharacters()
        {
            Console.WriteLine("Type some text and press \'Enter\'");

            string inputStr = Console.ReadLine();
            
            Console.WriteLine(SwapFirstLast(inputStr));
        }


        /// <summary>
        /// 4. Read two integers from console. Calculate their sum. If values were equal print triple of their sum, otherwise print sum dividev by 8.
        /// </summary>
        static void PrintSum()
        {
            const string ERROR = "Error! Incorrect number!\nApplication will be closed";

            Console.WriteLine("Enter two numbers through \'Enter\'");

            if(IsNumber(Console.ReadLine(), out int firstNumber) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }

            Console.WriteLine("Good! Type next number");

            if(IsNumber(Console.ReadLine(), out int secondNumber) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }

            int sum = firstNumber + secondNumber;

            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"Triple of sum: {Math.Pow(sum, 3)}");
            }

            else
            {
                Console.WriteLine($"Sum divided by 8: {(double)sum / 8}");
            }

        }


        /// <summary>
        /// 5. Find largest and lowest value from three integers.
        /// </summary>
        /// <param name="numbersQty"></param>
        static void FindMinMaxValue(int numbersQty = 3)
        {
            const string ERROR = "Error! Incorrect number!\nApplication will be closed";

            int[] numArray = new int[numbersQty];

            Console.WriteLine($"Enter {numbersQty} numbers through \'Enter\', \n*note - only numbers allowed");

            for (int i = 0; i < numArray.Length; i++)
            {
                if(IsNumber(Console.ReadLine(), out int num) != true)
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                numArray[i] = num;
            }

            Array.Sort(numArray);

            Console.WriteLine($"Largest value = {numArray[numArray.Length-1]} \nLowest value = {numArray[0]}");

        }


        /// <summary>
        /// 6. Read string from console. Create new string where first 5 characters will be in upper case. If string is less then 5 characters do nothing. Print it.
        /// </summary>
        /// <param name="subStringLength"></param>
        static void ToUpperSubstring(int subStringLength = 5)
        {
            Console.WriteLine("Type some string longer than 5 characters");
            string inputStr = Console.ReadLine();

            if (inputStr.Length < subStringLength)
            {
                return;
            }

            var subStr = inputStr.Substring(0, subStringLength);

            var outStr = subStr.ToUpper() + inputStr.Substring(subStringLength, inputStr.Length - subStringLength);
 
            Console.WriteLine(outStr);
        }


        /// <summary>
        /// 7. Check if given integer is a multiple of 3 or a multiple of 7.
        /// </summary>
        static void CheckOnMultiple()
        {
            const string ERROR = "Error! Incorrect value!\nApplication will be closed";

            Console.WriteLine("Enter some number to check if it is multiple of 3 or 7");

            if (IsNumber(Console.ReadLine(), out int number) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }

            var result = IsMultiple(number, 3, 7);

            Console.WriteLine(result);
        }


        /// <summary>
        /// 8. Check if given string starts from 'C#'.
        /// </summary>
        static void CheckStartString()
        {
            string keyString = "C#";

            Console.WriteLine($"Type your text to check if it starts from \'{keyString}\'");

            var inputStr = Console.ReadLine();

            Console.WriteLine($"{inputStr.StartsWith(keyString)}");
        }


        /// <summary>
        /// 9. Read circle radius from console. Calculate it's perimeter and area.
        /// </summary>
        static void ShowCirclePerimeterArea()
        {
            const string ERROR = "Error! Incorrect value!\nApplication will be closed";

            Console.WriteLine("Enter circle radius to calculate it's perimeter and area");

            if (IsNumber(Console.ReadLine(), out double radius) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }
            
            double length = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Length: {length}, area: {area}");
        }


        /// <summary>
        /// 10. In a loop read 10 numbers from keyboard. Find their sum and average.
        /// </summary>
        static void CalcSumAverage()
        {
            const string ERROR = "Error! Incorrect value!\nApplication will be closed";

            int sum = 0;

            Console.WriteLine("Enter 10 numbers one by one");

            int i = 1;
            while (true)
            {
                if(i > 10)
                {
                    break;
                }

                if(IsNumber(Console.ReadLine(), out int number) != true)
                {
                    Console.WriteLine(ERROR);
                    return;
                }

                sum += number;

                i++;
            }

            Console.WriteLine($"Sum: {sum}, average: {(double)sum / 10}");
        }


        /// <summary>
        /// 11. Write a program to display multiplication table from 1 to n.
        /// </summary>
        static void ShowMatrix()
        {
            const string ERROR = "Error! Incorrect value!\nApplication will be closed";

            Console.WriteLine("Enter dimention of required matrix");

            if(IsNumber(Console.ReadLine(), out int dim) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }

            for (int i = 1; i <= dim; i++)
            {
                for (int j = 1; j <= dim; j++)
                {
                    Console.Write($"{i}*{j}={i * j}\t");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// 12. Read two integers. Print all numbers in range between first and second number that are divisible by 8. If range is invalid print error message.
        /// </summary>
        /// <param name="dividerNum"></param>
        static void PrintNumbersInRAnge(int dividerNum = 8)
        {
            int divuder = dividerNum;

            const string ERROR = "Error! Incorrect value!\nApplication will be closed";

            Console.WriteLine($"Enter two numbers (min and max) of range to dispaly all numbers in range between first and second number that are divisible by \'{divuder}\'");

            if (IsNumber(Console.ReadLine(), out int firstNum) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }

            if (IsNumber(Console.ReadLine(), out int secondNum) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }

            bool flagError = true;

            for (int i = firstNum + 1; i < secondNum; i++)
            {
                if (i % divuder == 0)
                {
                    Console.WriteLine(i);
                    flagError = false;
                }
            }

            if (flagError)
            {
                Console.WriteLine("Error! No values found");
            }
        }


        /// <summary>
        /// 13. Create enum type for TV channels (5 is enough). Write a switch statement that provides channel avarage rating.
        /// </summary>
        static void TVChannelsRating()
        {
            const string ERROR = "Error! Incorrect channel number!\nApplication will be closed";

            Console.WriteLine($"Enter channel num to see it's rating \nChannels: \n1: {TVChannels.Discovery} \n2: {TVChannels.FirstNational} \n3: " +
                $"{TVChannels.STB} \n4: {TVChannels.TV1000} \n5: {TVChannels.TVbox}");
            
            if(IsNumber(Console.ReadLine(), out int num) != true)
            {
                Console.WriteLine(ERROR);
                return;
            }

            switch ((TVChannels)num)
            {
                case TVChannels.FirstNational:
                    Console.WriteLine("Rating: 3 of 10");
                    break;
                case TVChannels.STB:
                    Console.WriteLine("Rating: 6 of 10");
                    break;
                case TVChannels.TVbox:
                    Console.WriteLine("Rating: 4 of 10");
                    break;
                case TVChannels.Discovery:
                    Console.WriteLine("Rating: 9 of 10");
                    break;
                case TVChannels.TV1000:
                    Console.WriteLine("Rating: 7 of 10");
                    break;
                default:
                    Console.WriteLine("Unknown channel");
                    break;
            }

        }


        #region Helpers

        static bool IsNumber(string inputString, out int number)
        {
            bool status = Int32.TryParse(inputString, out int result);
            number = result;
            return status;
        }

        static bool IsNumber(string inputString, out double number)
        {
            bool status = double.TryParse(inputString, out double result);
            number = result;
            return status;
        }

        static string SwapFirstLast(string inputString)
        {
            StringBuilder str = new StringBuilder(inputString);
            var firstStr = inputString[0];

            var lastStr = inputString[inputString.Length - 1];

            str.Replace(firstStr, lastStr, 0, 1);

            str.Replace(lastStr,firstStr,str.Length - 1, 1);

            return str.ToString();
        }

        static bool IsMultiple(int number, params int[] multipliers)
        {
            foreach (var i in multipliers)
            {
                if ((number % i) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        enum TVChannels
        {
            FirstNational = 1,
            STB,
            TVbox,
            Discovery,
            TV1000,
        }

        #endregion

    }
}
