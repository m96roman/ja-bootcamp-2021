using System;

namespace NestorPylatLecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 //////////////////////////////////////////////
            /*int number = 10987;
            byte smallNumber = 11;
            string word = "ANY WORD";
            Console.WriteLine(number);
            Console.WriteLine(smallNumber);
            Console.WriteLine(word);
            Console.WriteLine(nameof(number));
            Console.WriteLine(nameof(word));
            Console.WriteLine($"name of number is {nameof(number)}");*/



            // 2 //////////////////////////////////////////////
            /* string firstNumber;
             string secondNumber;
             string thirdNumber;

             Console.WriteLine("input 1 number");
             firstNumber = Console.ReadLine();
             int intFirstNumber = int.Parse(firstNumber);

             Console.WriteLine("input 2 number");
             secondNumber = Console.ReadLine();
             int intSecondNumber = int.Parse(secondNumber);

             Console.WriteLine("input 3 number");
             thirdNumber = Console.ReadLine();
             int intThirdNumber = int.Parse(thirdNumber);

             Console.WriteLine(intFirstNumber*intSecondNumber*intThirdNumber);*/


            // 3//////////////////////////////////////////////

            /*string input = Console.ReadLine();

            StringBuilder word = new StringBuilder(input);

            char firstLetter = word[0];
            char lastletter = word[word.Length - 1];
            word[0] = lastletter;
            word[word.Length - 1] = firstLetter;
            Console.WriteLine(word);*/


            // 4//////////////////////////////////////////////

            /*int res;
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            if (number1 == number2) {
                Console.WriteLine((number1 + number2) * 3);
            } else Console.WriteLine( (number1 + number2) / 8);*/



            //5//////////////////////////////////////////////

            /* string strNum1;
              string strNum2;
              string strNum3;

              strNum1 = Console.ReadLine();
              int num1 = int.Parse(strNum1);

              strNum2 = Console.ReadLine();
              int num2 = int.Parse(strNum2);

              strNum3 = Console.ReadLine();
              int num3 = int.Parse(strNum3);

              int[] array = new int[3];

              array[0] = num1;
              array[1] = num2;
              array[2] = num3;

              Console.WriteLine(array.Max());
              Console.WriteLine(array.Min());*/



            // 6//////////////////////////////////////////////


            /* string word = Console.ReadLine();
             string firstPart;
             string secondPart;
             string result;

             if (word.Length >= 5)
             {
                 firstPart = word.Substring(0, 5);
                 secondPart = word.Substring(5, word.Length - 5);
                 firstPart = firstPart.ToUpper();
                 result = firstPart + secondPart;
                 Console.WriteLine(result);

             }
             else Console.WriteLine(word);*/



            // 7//////////////////////////////////////////////

            /* string strInput = Console.ReadLine();
              int input = int.Parse(strInput);

              if (input % 3 == 0 || input % 7 == 0)
              {
                  Console.WriteLine(true);
              }
              else Console.WriteLine(false);*/


            // 8
            /*
                        string input = Console.ReadLine();

                        Console.WriteLine(input.StartsWith("C#"));
            */


            // 9//////////////////////////////////////////////

            /*string strRadius = Console.ReadLine();
            int radius = int.Parse(strRadius);
            double p = 2*3.14*radius;double s = Math.Pow(radius, 2) * 3.14;

                        Console.WriteLine(s);
                        Console.WriteLine(p);*/



            // 10//////////////////////////////////////////////


            /* int input;
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
 
                    input = Convert.ToInt32(Console.ReadLine());
 
                    sum = sum + input;
 
 
                }
                Console.WriteLine(sum);*/



            // 11//////////////////////////////////////////////


            /* int input = Convert.ToInt32(Console.ReadLine());
 
             for(int i = 1; i <= input; i++)
             {
                    for (int j = 1; j <= input; j++)
                 {
                     Console.WriteLine($"{i}*{j} = {i * j}");
                 }
             }*/


            // 12//////////////////////////////////////////////


            /* int number1 = Convert.ToInt32(Console.ReadLine());
              int number2 = Convert.ToInt32(Console.ReadLine());
              int count = 0;
 
              for (int i = number1; i < number2; i++)
              {
                  if(i%8 == 0)
                  {
                      count++;
                  }
              }
 
              Console.WriteLine(count);*/

            // 13 ////////////////////////////////////////


            /*Chanels chanel = Chanels.tv1;
            switch (chanel)
            {
                case Chanels.tv1:
                    { 
                        Console.WriteLine("Rate 1");
                        break;
                    }
                  
                case Chanels.tv2:
                    {
                        Console.WriteLine("Rate 2");
                        break;

                    }
                    case Chanels.tv3:
                    {
                        Console.WriteLine("Rate 3");
                        break;

                    }
                case Chanels.tv4:
                    {
                        Console.WriteLine("Rate 3");
                        break;

                    }
                case Chanels.tv5:
                    {
                        Console.WriteLine("Rate 3");
                        break;

                    }
                default:
                    {
                        Console.WriteLine("No Rate");
                        break;
                    }
            }*/
        }
    }

   /* enum Chanels
    {
        tv1,
        tv2,
        tv3,
        tv4,
        tv5
    }*/
    }
