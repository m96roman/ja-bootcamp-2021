﻿using System;

namespace myfirstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Task8();

        }
        static void Task2()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 * number2 * number3);
        }
        static void Task3()
        {
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            char swap = chars[0];
            chars[0] = chars[chars.Length - 1];
            chars[chars.Length - 1] = swap;
            string str1 = new string(chars);
            Console.WriteLine(str1);

        }
        static void Task4()
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
        static void Task5()
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
            else if (numbers3 > maxvalue)
                {
                    maxvalue = numbers3;

                }
            
            if (numbers2 < minvalue)
            {
                minvalue = numbers2;
            }
            else if (numbers3 < minvalue)
                {
                    minvalue = numbers3;
                }
            

            Console.WriteLine("Largest value = " + maxvalue.ToString());
            Console.WriteLine("Lowest value = " + minvalue.ToString());


        }
        static void Task6()
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
        static void Task7()
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
        static void Task8()
        {
            string str = Convert.ToString(Console.ReadLine());
            if (str.StartsWith("C#"))
            {
                
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void Task9()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("perimetr=" + Math.PI * 2 * radius);
            Console.WriteLine("area=" + Math.PI * radius * radius);
        }
        static void Task10()
        {
           
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += Convert.ToDouble(Console.ReadLine());
                
            }
            Console.WriteLine($"Sum={sum}, avg={sum / 10}");
        }
        static void Task11() {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= number; j++)
                {
                    Console.Write(i + "x" + j + "=" + i * j+" ");
                }
            }
        }
        static void Task12()
        {

            int number1= Convert.ToInt32(Console.ReadLine());
            int number2= Convert.ToInt32(Console.ReadLine());
            if (number1>number2)
            {
                Console.WriteLine("Exception: number 1 < number 2");
                Console.ReadLine();
            }
            int count = 0;
            for (int i = number1; i <= number2; i++)
            {
                if (i%8==0)
                {
                    Console.WriteLine(i);
                    count += 1;
                }
            }
            Console.WriteLine("Count = " + count);
        }
        static void Task13()
        {
            int selectedChanel = Convert.ToInt32(Console.ReadLine());
            switch ((EmpTypeEnum)selectedChanel)
            {
                case EmpTypeEnum.chanel1:
                    Console.WriteLine("Chanel rating 81%");
                    break;
                case EmpTypeEnum.chanel2:
                    Console.WriteLine("Chanel rating 82%");
                    break;
                case EmpTypeEnum.chanel3:
                    Console.WriteLine("Chanel rating 83%");
                    break;
                case EmpTypeEnum.chanel4:
                    Console.WriteLine("Chanel rating 84%");
                    break;
                case EmpTypeEnum.chanel5:
                    Console.WriteLine("Chanel rating 85%");
                    break;
                default:
                    Console.WriteLine("Chanel not exist");
                    break;
            }
        }
        enum EmpTypeEnum  
        {
            chanel1 = 1,
            chanel2 = 2,
            chanel3 = 3,
            chanel4 = 4,
            chanel5=5
        }
    }
}
