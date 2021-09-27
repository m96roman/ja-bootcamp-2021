using System;

namespace myfirstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            task10();

        }
        static void task2()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 * number2 * number3);
        }
        static void task3()
        {
            string str = Convert.ToString(Console.ReadLine());
            char[] chars = str.ToCharArray();
            char swap = chars[0];
            chars[0] = chars[chars.Length - 1];
            chars[chars.Length - 1] = swap;
            string str1 = new string(chars);
            Console.WriteLine(str1);

        }
        static void task4()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            double amount = number1 + number2;
            if (number1 == number2)
            {
                Console.WriteLine(amount * 3);
            }
            else
            {
                Console.WriteLine(amount / 8);
            }

        }
        static void task5()
        {

            int numbers1 = Convert.ToInt32(Console.ReadLine());
            int numbers2 = Convert.ToInt32(Console.ReadLine());
            int numbers3 = Convert.ToInt32(Console.ReadLine());
            int maxvalue = numbers1;
            int minvalue = numbers1;

            if (numbers2 > maxvalue)
            {
                maxvalue = numbers2;
            }
            else
            {
                if (numbers3 > maxvalue)
                {
                    maxvalue = numbers3;

                }
            }
            if (numbers2 < minvalue)
            {
                minvalue = numbers2;
            }
            else
            {
                if (numbers3 < minvalue)
                {
                    minvalue = numbers3;
                }
            }

            Console.WriteLine("Largest value = " + maxvalue.ToString());
            Console.WriteLine("Lowest value = " + minvalue.ToString());


        }
        static void task6()
        {
            string str = Convert.ToString(Console.ReadLine());




            if (str.Length < 5)
            {
                Console.WriteLine(str);

            }
            else
            {
                string str1 = str.Substring(0, 5).ToUpper();

                str = str1 + str.Substring(5, str.Length - 5);
                Console.WriteLine(str);

            }
        }
        static void task7()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0 || number % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void task8()
        {
            string str = Convert.ToString(Console.ReadLine());
            if (str.Substring(0, 2) == "C#")
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void task9()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("perimetr=" + Math.PI * 2 * radius);
            Console.WriteLine("area=" + Math.PI * radius * radius);
        }
        static void task10()
        {
            double[] numbers = new double[10];
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine("Sum=" + sum + "    avg=" + sum / 10);
        }
    }
}
