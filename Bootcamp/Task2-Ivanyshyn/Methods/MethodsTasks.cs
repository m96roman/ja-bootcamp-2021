using System;
using Task2_Ivanyshyn.Helpers;

namespace Task2_Ivanyshyn.MethodTasks
{

    internal class MethodsTasks
    {

        internal static void doTasks()
        {
            //1.Write a program to create a function to swap the values of two integer numbers.
            //Test Data :
            //Enter a number: 5
            //Enter another number: 6
            //Expected Output :
            //Now the 1st number is : 6 , and the 2nd number is : 5

            //Task1();


            //2.Create a struct Point (X, Y) and method TryParsePoint, requirements to TryParsePoint:
            //    - Valid input is coma-separated value: `2,3` or `8, 88` anything else is considered invalid.
            //    - method returns `true` if input is parsed successfully, otherwise - false.
            //    - method returns parsed `Point` instance via `out` argument. in case of invalid input - `null` is returned.
            //Test Data :
            //    - Input your point: 8, 88
            //    - Input your point: hehe, wrong
            //Expected output: 
            //    - Result of parsing: true, Point = (8, 88)
            //    - Result of parsing: false, Point = undefined
            Task2();
        }

        private static void Task2()
        {
            Console.WriteLine("Enter point:");
            var str = Console.ReadLine();
            Point point;
            Console.WriteLine($"Result of parse is {Point.TryParsePoint(str, out point)} Point= {point}");


        }

        private static void Task1()
        {
            var number1 = Reader.ReadDouble();
            var number2 = Reader.ReadDouble();
            Console.WriteLine($"{nameof(number1)}={number1}, {nameof(number2)}={number2}");
            Swap(ref number1, ref number2);
            Console.WriteLine($"{nameof(number1)}={number1}, {nameof(number2)}={number2}");
        }

        private static void Swap(ref double number1, ref double number2)
        {
            var dummy = number1;
            number1 = number2;
            number2 = dummy;
        }
    }
}