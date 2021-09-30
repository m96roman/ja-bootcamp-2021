using System;

namespace AntonDvgHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            int value = 20;
            Console.WriteLine($"{nameof(value)} = {value}");
        }

        static void Task2()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNum * secondNum * thirdNum);

        }

        static void Task3()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            char first = str[0];
            char last = str[str.Length - 1];
            char[] strArr = str.ToCharArray();
            strArr[0] = last;
            strArr[strArr.Length - 1] = first;

            string result = string.Join("", strArr);

            for (int i = 0; i < strArr.Length; i++)
            {
                result += strArr[i];
            }

            Console.WriteLine(result);
        }

        static void Task4()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int sum = firstNum + secondNum;

            if (firstNum == secondNum)
            {
                Console.WriteLine(sum * 3);
            }
            else
            {
                Console.WriteLine(sum / 8);
            }

        }
        static void Task5()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Largest value = {Math.Max(firstNum, Math.Max(secondNum, thirdNum))}");
            Console.WriteLine($"Lowest value = {Math.Min(firstNum, Math.Min(secondNum, thirdNum))}");
        }
        static void Task6()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            int length = str.Length;
            
            if (length < 5)
            {
                Console.WriteLine($"{length}");
            }

            string res = "";

            for (int i = 0; i < length; i++)
            {
                if (i < 5)
                {
                    res += str[i].ToString().ToUpper();
                }
                else
                {
                    res += str[i];
                }

            }
            Console.WriteLine(res);
        }

        static void Task7()
        {
            Console.WriteLine("Enter an integer: ");
            int someInt = int.Parse(Console.ReadLine());
            Console.WriteLine(someInt % 3 == 0 || someInt % 7 == 0);
        }

        static void Task8()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            if (str.StartsWith("C#"))
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine("Given string starts with C#");
            }

        }
        static void Task9()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Perimeter of the circle = {perimeter}");
            Console.WriteLine($"Area of the circle = {area}");
        }

        static void Task10()
        {
            double sum = 0;
            int length = 10;
            Console.WriteLine($"Enter {length} numbers from keyboard");

            for (int i = 0; i < length; i++)
            {
                sum += int.Parse(Console.ReadLine());

            }
            double avg = sum / length;

            Console.WriteLine($"Sum = {sum}, Average = {avg}");
        }

        static void Task11()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    Console.Write($"{i}x{j}={i * j} ");
                }
                Console.WriteLine();
            }
        }
        static void Task12()
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int counter = 0;

            if (numA < numB)
            {
                for (int i = numA; i < numB; i++)
                {
                    if (i % 8 == 0)
                    {
                        Console.WriteLine(i);
                        counter++;
                        i += 7;
                    }
                }
            }
            else
            {
                Console.WriteLine("Range is invalid");
            }
            Console.WriteLine($"Numbers in range diviseble by 8: { counter }");

        }

        static void Task13()
        {
            Console.WriteLine("enter number of chanel:");
            int chanel = int.Parse(Console.ReadLine());
            var rating = 0;

            switch (chanel)
            {
                case (int) TvChanelsEnum.ChanelOne:
                    rating = 68;
                    break;
                case (int) TvChanelsEnum.ChanelTwo:
                    rating = 90;
                    break;
                case (int) TvChanelsEnum.ChanelThree:
                    rating = 85;
                    break;
                case (int) TvChanelsEnum.ChanelFour:
                    rating = 70;
                    break;
                case (int) TvChanelsEnum.ChanelFive:
                    rating = 80;
                    break;
            }

            Console.WriteLine($"Chanel {chanel} average rating: {rating}");
        }
        enum TvChanelsEnum
        {
            ChanelOne,
            ChanelTwo,
            ChanelThree,
            ChanelFour,
            ChanelFive
        }
    }
}
