using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("1");
            NameOfAndInterpolation();

            Print("2");
            Console.WriteLine("Write three numbers trought ,");
            var numbers = Array.ConvertAll(Console.ReadLine().Split(","), Double.Parse);
            Console.WriteLine($" The result of multiplication {Multiplication(numbers)}");

            Print("3");
            Console.WriteLine("Write word");
            var word = Console.ReadLine();
            Console.WriteLine($"Swap letters in word :{word} => {Swap(word)}");

            Print("4");
            Console.WriteLine("Write two integers trought ,");
            var numbersToSum = Array.ConvertAll(Console.ReadLine().Split(","), decimal.Parse);
            SumOfNumbersIfEqual(numbersToSum);

            Print("5");
            Console.WriteLine("Write three integers trought ,");
            var numbersMaxAndMin = Array.ConvertAll(Console.ReadLine().Split(","), Int32.Parse);
            MaxAndMinInt(numbersMaxAndMin);

            Print("6");
            Console.WriteLine("Write a string");
            FiveUpperChar(Console.ReadLine());

            Print("7");
            Console.WriteLine("Write a number");
            Multiple3Or7(Int32.Parse(Console.ReadLine()));

            Print("8");
            Console.WriteLine("Write a string");
            StartWithCSharp(Console.ReadLine());

            Print("9");
            Console.WriteLine("Input the radius of the circle : ");
            CirclePerimeterAndArea(Double.Parse(Console.ReadLine()));

            Print("10");
            Console.WriteLine("Write 10 integers trought space");
            var numbersSumAndAvg = Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse);
            SumAndAvg(numbersSumAndAvg);

            Print("11");
            Console.WriteLine("Write a program to display multiplication table from 1 to n \n Write n :");
            MultiplicationTable(Int32.Parse(Console.ReadLine()));

            Print("12");
            Console.WriteLine("Write two integers trought space");
            var numbersDivideBy8 = Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse);
            NumbersDivisibleBy8(numbersDivideBy8);

            Print("13");
            Console.WriteLine();
            Channel channel = Channel.TV1;
            TvAvarageRating(channel);
        }

        public static void NameOfAndInterpolation()
        {
            var number = 10;
            var word = "dog";
            Console.WriteLine($"Variable {nameof(number)} and it`s value  {number}");
            Console.WriteLine($"Variable {nameof(word)} and it`s value {word}");
        }

        public static double Multiplication(double[] numbers)
        {
            double result = 1;
            foreach (var number in numbers)
            {
                result *= number;
            }
            return result;
        }

        public static string Swap(string str)
        {
            var length = str.Length;
            return str[length - 1] + str.Substring(1, length - 2) + str[0];
        }

        public static void SumOfNumbersIfEqual(decimal[] numbers)
        {
            var sum = numbers[0] + numbers[1];
            Console.WriteLine(numbers[0].Equals(numbers[1]) ? $"triple of their sum \n {sum * 3}" : $"sum dividev by 8 \n {sum / 8}");

        }
        public static void Print(string str)
        {
            Console.WriteLine($"--------------------------------------------------------------------------------------------\n Task #{str}");
        }
        public static void MaxAndMinInt(int[] arrayOfNumbers)
        {

            Console.WriteLine("Largest of three: " + Math.Max(arrayOfNumbers[0], Math.Max(arrayOfNumbers[1], arrayOfNumbers[2])));
            Console.WriteLine("Lowest of three: " + Math.Min(arrayOfNumbers[0], Math.Min(arrayOfNumbers[1], arrayOfNumbers[2])));

        }
        public static void FiveUpperChar(string str)
        {

            Console.WriteLine(str.Length < 5 ? $"String: {str} " : $"String:{str.Substring(0, 5).ToUpper() + str.Substring(5, str.Length - 5)}");
        }
        public static void Multiple3Or7(int number)
        {
            Console.WriteLine(number % 3 == 0 || number % 7 == 0);
        }
        public static void StartWithCSharp(string str)
        {
           
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("The string is empty!");
            }
            str=str.ToUpper();
            bool first= str.StartsWith("C#");
            Console.WriteLine(first);
            
        }
        public static void CirclePerimeterAndArea(double radius)
        {
            double per_cir = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Perimeter of Circle {per_cir}");
            Console.WriteLine($"Area of circle: {area}");
        }
        public static void SumAndAvg(int[] numbers)
        {
            int sum=0;
            foreach (var number in numbers)
            {
                sum += number;
            }
           double  avg = sum / 10.00;
            Console.WriteLine($"The sum of 10 no is : {sum}\nThe Average is : {avg}\n");

        }
        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                        Console.Write($"{i}x{j}={i * j} ");
                }
                Console.WriteLine("");
            }
        }
        public static void NumbersDivisibleBy8(int[] numbers)
        {
            int count = 0;
            if (numbers[0] > numbers[1])
            {
                Console.WriteLine("The range is invalid");
            }
            else
            {
                for (int i = numbers[0]; i < numbers[1]; i += 8)
                {
                        count++;
                }
                Console.WriteLine(count);

            }
        }
        public static void TvAvarageRating( Channel e) {
            switch (e)
            {
                case Channel.TV1:
                    Console.WriteLine("The TV1 is cool!");
                    break;
                case Channel.TV2:
                    Console.WriteLine("The TV2 is cool!");
                    break;
                case Channel.TV3:
                    Console.WriteLine("The TV3 is cool!");
                    break;
                case Channel.TV4:
                    Console.WriteLine("The TV4 is cool!");
                    break;
                case Channel.TV5:
                    Console.WriteLine("The TV5 is cool!");
                    break;
            }

        }
    }
    enum Channel
    {
        TV1,
        TV2,
        TV3,
        TV4,
        TV5
    };
}
