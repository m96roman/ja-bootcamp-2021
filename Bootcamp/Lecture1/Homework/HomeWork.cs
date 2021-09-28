using System;

namespace BootCampTask
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("1.Create variable and initialize it with any value.Write into console variable name and it's value using nameof operator and interpolation.");

            string name = "Viktoriia";
            Console.WriteLine($"My name is {name}");
            Console.WriteLine("My name is " + nameof(name));

            Console.WriteLine("2. Read three numbers from console and print their multiplication.");

            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("One more please:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("And the last one:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int multyplied = num1 * num2 * num3;

            Console.WriteLine($"Multiplication of those numbers is {multyplied}");


            Console.WriteLine("3.Swap first and last characters of a given string.Write result to console.");

            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            int lastIndex = word.Length - 1;
            string firstLetter = word.Substring(0, 1);
            string lastLetter = word.Substring(lastIndex, 1);
            string middlePart = word.Substring(1, lastIndex-1);
            string result = lastLetter + middlePart + firstLetter;

            Console.WriteLine(result);


            Console.WriteLine("4. Read two integers from console. Calculate their sum. If values were equal print triple of their sum, otherwise print sum dividev by 8.");

            Console.WriteLine("Enter a number");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter one more number");
            double num5 = Convert.ToDouble(Console.ReadLine());
           
            if (num4 == num5)
            {
                Console.WriteLine($"Numbers ar equal. Number in 3d paw is {Math.Pow(num4, 3)}");
            }
            else
            {
                Console.WriteLine($"Numbers are not equal. Their sum devided by 8 is {num4 * num5 / 8}");
            }



            Console.WriteLine("5.Find largest and lowest value from three integers.");


            Console.WriteLine("Enter a number:");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("One more please:");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and the last one:");
            int num8 = Convert.ToInt32(Console.ReadLine());
            int theBiggest = default;
            int theLowest = default;

            theBiggest = ((num6 > num7) ? num6: num7);
            theBiggest = ((theBiggest > num8) ? theBiggest : num8);

            theLowest = ((num6 < num7) ? num6 : num7);
            theLowest = ((theLowest < num8) ? theLowest : num8);

            Console.WriteLine($"Largest value = {theBiggest}");
            Console.WriteLine($"Lowest value = { theLowest}");


          
            Console.WriteLine("6. Read string from console. Create new string where first 5 characters will be in upper case. If string is less then 5 characters do nothing. Print it.");

            Console.WriteLine("Enter a word in lowercase, please:");

            string yourWord = Console.ReadLine();
            if (yourWord.Length < 5)
            {
                Console.WriteLine("The word is too small");
            }
            else
            { 
                string wordUpper = yourWord.Substring(0, 5);
                wordUpper = wordUpper.ToUpper();
                string remainingPart = yourWord.Substring(6);
                Console.WriteLine(remainingPart);
                string result2 = ($"{wordUpper}{remainingPart}");
                Console.WriteLine(result2); 
            }


            Console.WriteLine("7. Check if given integer is a multiple of 3 or a multiple of 7.");

            Console.WriteLine("Enter a number");
            int num9 = Convert.ToInt32(Console.ReadLine());


            if ((num9 % 3) == 0 && (num9 % 7) == 0)
            {
                Console.WriteLine($"Number {num9} is devided by 3 either by 7");
            } 
            else if((num9 % 3) == 0)
            {
                Console.WriteLine($"Number {num9} is devided by 3");
            }
            else if ((num9 % 7) == 0)
            {
                Console.WriteLine($"Number {num9} is devided by 7");
            }
            else
            {
                Console.WriteLine($"Number {num9} can not be devided by 3 either by 7");

            }



            //8. Check if given string starts from 'C#'.



            Console.WriteLine("9. Read circle radius from console. Calculate it's perimeter and area.");

            Console.WriteLine("Enter a circle radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            int diameter = radius * 2;
            double pNumber = 3.14;
            Console.WriteLine($"The area of the circle with radius {radius} is {(radius*radius) * pNumber} ");
            Console.WriteLine($"The perimetes of the circle with radius {radius} is {diameter * pNumber} ");


            //10. In a loop read 10 numbers from keyboard. Find their sum and average.

            //11. Write a program to display multiplication table from 1 to n.


            Console.WriteLine("12. Read two integers. Print all numbers in range between first and second number that are divisible by 8. If range is invalid print error message.");
            
            Console.WriteLine("Enter a number");
            int num10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one more number, that is bigger then the first");
            int num11 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("numbers, that can be devided by 8 are:");
            for (int i = num10; i < num11; i++)
            {
                if (i % 8 == 0) { Console.WriteLine(i); }
                
            }


            //13. Create enum type for TV channels (5 is enough). Write a switch statement that provides channel avarage rating.

           

        }
    }
}
   