using System;

namespace Task1_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Swap(ref number1, ref number2);
            Console.WriteLine($"Now the 1st number is : {number1} , and the 2nd number is : {number2}");
        }

        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
